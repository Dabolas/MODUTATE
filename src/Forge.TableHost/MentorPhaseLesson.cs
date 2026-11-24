using Planeswalker.Core;
using Planeswalker.ForgeAot;
using Planeswalker.ForgeConsole;
using Planeswalker.TableHost;

public sealed partial class HeadlessMatch
{
    private const string PhaseHandler = "forge/game/phase/PhaseHandler";
    private const string LessonSurvivorName = "Centaur Courser";
    private const int LessonHandLimit = 7;
    private const string StackLine = "咒语和大多数异能会先进入堆叠。所有牌手依次让过后，最上方的一项先结算。";
    private static readonly string[] PhaseLines = {
        "对手回合可施放瞬间。单击闪电击，在右侧黄框看描述，再双击施放。",
        "你的永久物重置了，用掉的资源回来了。重置是回合动作，不经过堆叠。",
        "维持阶段：Thrumming Hivepool 触发，创造两个 1/1 裂片妖。",
        "抓一张牌。牌库空了还必须抓牌时，你会输掉对局。",
        "第一主阶段堆叠为空时，可以下地或施放法术。单击连锁闪电看描述，双击施放。",
        "先点亮框的 3/3 和裂片妖，再确认攻击。顶部的异能查找可查看连击。",
        "在第二个主阶段，如果你在本回合内还未下地，你可以在此阶段拍下一块地。",
        "这场练习特意给了你较多起手牌。结束步骤之后进入清理，手牌超过七张便要弃牌。",
        "先选择要弃的牌，留下七张。随后清除伤害，直到回合结束的效果也会结束。"
    };
    private MentorPhaseFixture? phaseLesson;
    private Action<MentorPhaseEvidence>? phaseEvidence;
    private JValue[] lessonBears = Array.Empty<JValue>();
    private JValue lessonSurvivor;
    private int lessonStep;
    private int lessonRecordedInput;
    private int landsPlayedBeforeSecondMain;
    private bool lessonStepDone, lessonFirstStrike, lessonSecondMainPassed;
    private string lessonGate = "";

    public static HeadlessMatch CreateMentorPhasePractice(CardDatabase db, byte[] types, byte[] messages,
        MentorPhaseFixture fixture, Action<MentorPhaseEvidence>? evidence = null)
    {
        return new HeadlessMatch(db, types, messages, Array.Empty<string>(), Array.Empty<string>(), fixture.Seed) {
            phaseLesson = fixture, phaseEvidence = evidence
        };
    }

    private string LessonPhase => g.Rt.InspectEnumName(C(g.Phase, "getPhase", "()Lforge/game/phase/PhaseType;")) ?? "";
    private string? LessonSpell => lessonStep switch { 1 => "Lightning Bolt", 5 => "Chain Lightning", 7 => "Brute Force", _ => null };
    private int LessonCardId(JValue card) => C(card, "getId", "()I").Int;
    private int LessonSurvivorDamage => C(g.Current(lessonSurvivor), "getDamage", "()I").Int;
    private int LessonLandsPlayed => C(g.Players[0], "getLandsPlayedThisTurn", "()I").Int;
    private JValue[] LessonSlivers() => Zone(0, "Battlefield").Where(card => B(card, "isToken") && Name(card) is "Sliver Token" or "Sliver")
        .OrderBy(LessonCardId).ToArray();

    private void StartPhaseLesson()
    {
        var fixture = phaseLesson!;
        opening = false;
        var rival = g.Players[1];
        C(g.Game, "setAge", "(Lforge/game/GameStage;)V", g.Enum("forge/game/GameStage", "Play"));
        C(g.Game, "setStartingPlayer", "(Lforge/game/player/Player;)V", rival);
        C(g.Phase, "setupFirstTurn", "(Lforge/game/player/Player;Ljava/lang/Runnable;)V", rival, default);
        foreach (var name in fixture.PlayerLibrary) g.Card(name, 0, "Library");
        foreach (var name in fixture.OpponentLibrary) g.Card(name, 1, "Library");
        foreach (var name in fixture.PlayerBattlefield) g.Card(name, 0, "Battlefield");
        lessonSurvivor = Zone(0, "Battlefield").Single(card => Name(card) == LessonSurvivorName);
        foreach (var name in fixture.PlayerHand) g.Card(name, 0, "Hand");
        lessonBears = fixture.OpponentBattlefield.Select(name => g.Card(name, 1, "Battlefield")).ToArray();
        C(g.Phase, "devModeSet", "(Lforge/game/phase/PhaseType;Lforge/game/player/Player;I)V",
            g.Enum("forge/game/phase/PhaseType", "END_OF_TURN"), rival, JValue.I(1));
        g.Rt.PutField(g.Phase, PhaseHandler, "givePriorityToPlayer", "Z", JValue.I(1));
        C(g.Action, "checkStateEffects", "(Z)Z", JValue.I(1));
        C(g.Game, "copyLastState", "()V");
        SetLessonStep(1);

        var phaseBegin = g.Rt.Program.Classes[PhaseHandler].Methods["onPhaseBegin()V"];
        g.Rt.Bind(PhaseHandler, "onPhaseBegin", "()V", (_, receiver, args) => {
            BeforeLessonPhase();
            return JHostResult.Schedule(new JFrame(phaseBegin, receiver, args));
        });
    }

    private void SetLessonStep(int step)
    {
        lessonStep = step;
        lessonStepDone = false;
    }

    private void RecordLessonPriorityInput()
    {
        if (lessonStep is 5 or 7) {
            var land = View.players[0].cards.FirstOrDefault(card => card.zone == "Hand" && card.canPlayLand);
            if (land != null) View.tutorialFocus = View.tutorialFocus.Append(land.id).ToArray();
        }
        if (lessonRecordedInput == lessonStep) return;
        var cards = View.players[0].cards;
        RequireLesson(cards.Any(card => card.zone == "Hand" && card.name == LessonSpell && card.canCast), "高亮咒语应可依法施放");
        if (lessonStep == 1)
            RequireLesson(cards.Any(card => card.zone == "Hand" && card.name == "Chain Lightning" && !card.canCast), "对手回合不能施放连锁闪电");
        lessonRecordedInput = lessonStep;
        ReportLesson("input", View);
    }

    private void BeforeLessonPhase()
    {
        if (Seat(C(g.Phase, "getPlayerTurn", "()Lforge/game/player/Player;")) != 0) return;
        switch (LessonPhase) {
            case "UNTAP":
                SetLessonStep(2);
                PauseLesson("phase", "before", "黄框标出了横置的山脉。重置会恢复这些资源，不经过堆叠。", "重置并继续");
                break;
            case "UPKEEP": SetLessonStep(3); break;
            case "DRAW": SetLessonStep(4); break;
            case "MAIN1": SetLessonStep(5); break;
            case "COMBAT_BEGIN": SetLessonStep(6); break;
            case "COMBAT_END":
                RequireLesson(lessonFirstStrike && g.Life(1) == 18, "未被阻挡的裂片妖应在两次伤害步骤各造成一点伤害");
                RequireLesson(g.In(lessonBears[2], "Graveyard") && g.In(lessonSurvivor, "Battlefield") && LessonSurvivorDamage == 2,
                    "3/3 应消灭阻挡的 2/2，并带两点伤害存活");
                CompleteLessonStep();
                break;
            case "MAIN2":
                landsPlayedBeforeSecondMain = LessonLandsPlayed;
                SetLessonStep(7);
                break;
            case "END_OF_TURN":
                if (!lessonStepDone) CompleteLessonStep();
                SetLessonStep(8);
                break;
            case "CLEANUP":
                RequireLesson(g.Count(0, "Hand") > LessonHandLimit, "开始清理时应有超额手牌可供玩家选择");
                RequireLesson(g.In(lessonSurvivor, "Battlefield") && LessonSurvivorDamage == 2, "战斗伤害应保留到清理步骤");
                SetLessonStep(9);
                ReportLesson("before", ProjectTable());
                break;
        }
    }

    private void FinishAutomaticLessonStep()
    {
        if (phaseLesson == null || lessonStepDone) return;
        switch (lessonStep) {
            case 2:
                RequireLesson(Zone(0, "Battlefield").Where(card => Name(card) == "Mountain").All(card => !B(card, "isTapped")), "两张山脉应已重置");
                CompleteLessonStep();
                break;
            case 4:
                RequireLesson(g.Count(0, "Library") == phaseLesson.PlayerLibrary.Length - 1 && Zone(0, "Hand").Any(card => Name(card) == phaseLesson.PlayerLibrary[0]), "应恰好抓到固定牌库的第一张牌");
                CompleteLessonStep();
                break;
            case 6 when LessonPhase == "COMBAT_FIRST_STRIKE_DAMAGE" && !lessonFirstStrike:
                RequireLesson(g.Life(1) == 19 && LessonSurvivorDamage == 0, "先攻伤害步骤应只有裂片妖对导师造成一点伤害");
                lessonFirstStrike = true;
                PauseLesson("phase", "first-strike-damage", "连击的第一段已对导师造成 1 点伤害。接下来结算普通战斗伤害。", "继续普通伤害");
                break;
            case 7 when lessonSecondMainPassed:
                CompleteLessonStep();
                break;
            case 8: CompleteLessonStep(); break;
            case 9:
                RequireLesson(g.Count(0, "Hand") == LessonHandLimit && Zone(0, "Battlefield").All(card => C(card, "getDamage", "()I").Int == 0), "完成弃牌后应留下七张手牌并清空伤害");
                RequireLesson(g.In(lessonSurvivor, "Battlefield") && LessonSurvivorDamage == 0, "3/3 的两点战斗伤害应在清理移除");
                var survivors = LessonSlivers();
                RequireLesson(survivors.Length == 2 && survivors.All(card => C(card, "getNetPower", "()I").Int == 1), "清理后两只裂片妖均应为 1/1");
                CompleteLessonStep();
                break;
        }
    }

    private bool TeachPriority(int seat)
    {
        if (seat != 0 || lessonStepDone) return false;
        if (Items(g.Stack).Length != 0) {
            string line = lessonStep == 3
                ? "维持开始，Thrumming Hivepool 的触发式异能进入堆叠。让过优先权后会派出两个裂片妖。"
                : StackLine;
            PauseLesson("stack", "stack", line, "让过优先权");
            return false;
        }
        switch (lessonStep) {
            case 1 when g.In(lessonBears[0], "Graveyard"):
                RequireLesson(Zone(0, "Battlefield").Any(card => Name(card) == "Mountain" && B(card, "isTapped")), "闪电击应已花费一张山脉的法术力");
                CompleteLessonStep(); return false;
            case 3 when LessonSlivers().Length == 2:
                RequireLesson(LessonSlivers().All(card => C(card, "getNetPower", "()I").Int == 1 && C(card, "getNetToughness", "()I").Int == 1),
                    "维持触发应派出两只 1/1 裂片妖");
                CompleteLessonStep(); return false;
            case 5 when g.In(lessonBears[1], "Graveyard"):
                CompleteLessonStep(); return false;
            case 7 when LessonLandsPlayed > landsPlayedBeforeSecondMain:
                CompleteLessonStep(); return false;
            case 7 when Zone(0, "Graveyard").Any(card => Name(card) == "Brute Force"):
                RequireLesson(LessonSlivers().Any(card => C(card, "getNetPower", "()I").Int == 4), "蛮力应使剩余裂片妖暂时成为 4/4");
                CompleteLessonStep(); return false;
            default: return lessonStep is 1 or 5 or 7;
        }
    }

    private bool PhaseLessonTarget(JValue entity)
    {
        var target = lessonStep switch {
            1 => lessonBears[0], 5 => lessonBears[1], 7 => LessonSlivers().FirstOrDefault(), _ => default
        };
        return target.Reference == null || ReferenceEquals(g.Current(target).Reference, entity.Reference);
    }

    private JHostResult PhaseLessonCombat(int seat, JValue combat, bool attacking)
    {
        if (seat == 0 && attacking) {
            var defender = g.Players[1];
            var attackers = new[] { g.Current(lessonSurvivor), LessonSlivers().First() };
            RequireLesson(attackers.All(attacker => S("forge/game/combat/CombatUtil", "canAttack",
                "(Lforge/game/card/Card;Lforge/game/GameEntity;)Z", attacker, defender).Int != 0), "两张高亮生物均应能攻击导师");
            var pairs = attackers.Select(attacker => (Card: attacker, Target: defender)).ToList();
            return ChooseAttackers(combat, pairs, requireAll: true);
        }
        if (seat == 1 && !attacking) {
            var attacker = Items(C(combat, "getAttackers", "()Lforge/game/card/CardCollection;"))
                .Single(card => LessonCardId(card) == LessonCardId(lessonSurvivor));
            var blocker = g.Current(lessonBears[2]);
            RequireLesson(S("forge/game/combat/CombatUtil", "canBlock", "(Lforge/game/card/Card;Lforge/game/card/Card;Lforge/game/combat/Combat;)Z", attacker, blocker, combat).Int != 0,
                "最后一只灰棕熊须能阻挡 3/3");
            C(combat, "addBlocker", "(Lforge/game/card/Card;Lforge/game/card/Card;)V", attacker, blocker);
            PauseLesson("phase", "blocked", "导师用 2/2 阻挡你的 3/3。裂片妖未被阻挡，会在两个伤害步骤各造成一次伤害。", "继续战斗伤害");
        }
        return JHostResult.Complete();
    }

    private void CompleteLessonStep()
    {
        lessonStepDone = true;
        switch (lessonStep) {
            case 3:
                PauseLesson("phase", "after", "维持触发已结算，两个 1/1 裂片妖进场。看完后可以继续到抓牌步骤。", "继续到抓牌");
                break;
            case 4:
                PauseLesson("phase", "after", "已抓一张牌。牌库空了还必须抓牌时会输。看完手牌后，再进入第一主阶段。", "继续到第一主阶段");
                break;
            case 6:
                PauseLesson("phase", "after", "你的 3/3 标记了 2 点伤害，离致命还差 1 点。伤害会保留到清理步骤。", "继续到第二主阶段");
                break;
            case 8:
                PauseLesson("phase", "after", $"你现在有 {g.Count(0, "Hand")} 张手牌。进入清理后，请选牌弃到七张。", "进入清理");
                break;
            case 9:
                PauseLesson("done", "after", "手牌已剩七张。3/3 的两点伤害已清除，本回合的临时效果也已结束。", "完成教程");
                break;
            default:
                ReportLesson("after", ProjectTable());
                break;
        }
    }

    private void PauseLesson(string gate, string evidence, string line, string button)
    {
        lessonGate = gate;
        string? command = gate switch { "stack" => "tutorial-resolve", "phase" => "tutorial-leave-phase", _ => null };
        PublishPrompt(line, (cmd, _) => cmd == command, command != null, button);
        ReportLesson(evidence, View, line);
        var wait = WaitForInlineInput ?? throw new InvalidOperationException("教学对局缺少输入所有者。");
        while (Waiting) wait();
        lessonGate = "";
    }

    private void ProjectPhaseLesson(MatchView view)
    {
        view.tutorialStep = lessonStep;
        view.tutorialGate = lessonGate;
        view.tutorialCue = lessonStep switch { 4 => "library", 8 => "hand", 9 => "battlefield", _ => "" };
        if (view.players.Length == 0 || (lessonStepDone && lessonGate.Length == 0) || (lessonGate == "stack" && lessonStep != 3)) return;
        var cards = view.players[0].cards;
        view.tutorialFocus = lessonStep switch {
            1 or 5 or 7 => cards.Where(card => card.zone == "Hand" && card.name == LessonSpell).Select(card => card.id).ToArray(),
            2 => cards.Where(card => card.zone == "Battlefield" && card.name == "Mountain" && card.tapped).Select(card => card.id).ToArray(),
            3 => cards.Where(card => card.zone == "Battlefield" && card.name == "Thrumming Hivepool").Select(card => card.id).ToArray(),
            4 => cards.Where(card => card.zone == "Hand" && card.name == phaseLesson!.PlayerLibrary[0]).Select(card => card.id).ToArray(),
            6 when lessonStepDone => new[] { LessonCardId(lessonSurvivor) },
            6 => cards.Where(card => card.zone == "Battlefield" && card.token && card.name is "Sliver Token" or "Sliver")
                .OrderBy(card => card.id).Take(1).Select(card => card.id).Append(LessonCardId(lessonSurvivor)).ToArray(),
            9 => new[] { LessonCardId(lessonSurvivor) },
            _ => Array.Empty<int>()
        };
    }

    public static string MentorPhaseLine(int step) => PhaseLines[step - 1];

    private void ReportLesson(string name, MatchView state, string? line = null) =>
        phaseEvidence?.Invoke(new(name, Seed, line ?? PhaseLines[lessonStep - 1], state));

    private static void RequireLesson(bool condition, string detail)
    {
        if (!condition) throw new InvalidOperationException("全阶段教学核对失败：" + detail);
    }
}
