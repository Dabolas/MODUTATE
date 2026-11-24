#nullable enable
namespace Planeswalker.Core
{
    // This DTO deliberately matches the existing table's wire schema. Only GetView builds it;
    // never serialize a RulesMatch or its private Card/Player objects.
    public sealed class MatchView
    {
        public int protocol=1, turn, activePlayerId, priorityPlayerId, selectedBlockerId, pendingAttackerId, promptCardId=-1;
        public long inputId;
        public bool declaringAttackers, declaringBlockers, canUndo, priorityWindow;
        public string status="playing", phase="", prompt="", okLabel="OK", cancelLabel="Cancel", error="";
        public string notice="";
        public int tutorialStep;
        public string tutorialGate="", tutorialCue="";
        public int[] tutorialFocus=System.Array.Empty<int>();
        public bool inputReady, ok, cancel, gameOver, targeting, manaPayment, lifePayment;
        public PlayerView[] players=System.Array.Empty<PlayerView>();
        public StackView[] stackItems=System.Array.Empty<StackView>();
        public string[] stack=System.Array.Empty<string>();
        public ChoiceView? choice;

        internal MatchView CopyForTable()
        {
            var copy=(MatchView)MemberwiseClone();
            copy.players=System.Array.ConvertAll(players,player=>player.CopyForTable());
            copy.choice=choice?.CopyForTable();
            return copy;
        }
    }
    public sealed class PlayerView
    {
        public int id, life, handCount, libraryCount;
        public bool local, lost, selectableDefender;
        public string name="";
        public CommandView command=new CommandView();
        public CardView[] cards=System.Array.Empty<CardView>();
        public ManaView[] manaPool=System.Array.Empty<ManaView>();
        public CounterView[] counters=System.Array.Empty<CounterView>();

        internal PlayerView CopyForTable()
        {
            var copy=(PlayerView)MemberwiseClone();
            copy.cards=System.Array.ConvertAll(cards,card=>card.CopyForTable());
            return copy;
        }
    }
    public sealed class CommandView { public bool protectedFromEverything,monarch,initiative,initiativeImplemented,dungeonImplemented,commanderImplemented; public int ringLevel,ringBearerId,ringTemptations; public string dungeon="",room=""; }
    public sealed class CardView
    {
        public int id, power, toughness, damage, blockingAttackerId;
        public int ownerId=-1,controllerId=-1,instanceId=-1;
        public string tokenKey="",artKey="",stackKey="",chosenType="";
        public string printedStats="",printedType="";
        public int preparedSpellId=-1;
        public string preparedSpell="";
        public string[] grantedAbilities=System.Array.Empty<string>(), namedCards=System.Array.Empty<string>(), chosenColors=System.Array.Empty<string>();
        public bool token,summoningSick;
        public bool canCast,canPlayLand,companion;
        public bool canProduceMana,canActivateAbility,canChannel,canCastPrepared,preparedCopy;
        public TargetView? attackTarget;
        public int[] blockingAttackerIds=System.Array.Empty<int>();
        public string name="", zone="", text="", type="", mana="";
        public bool snow, tapped, creature, land, actionable, selectable, chosen, attacking;
        public string[] keywords=System.Array.Empty<string>();
        public int[] attachments=System.Array.Empty<int>();
        public CounterView[] counters=System.Array.Empty<CounterView>();

        internal CardView CopyForTable()=>(CardView)MemberwiseClone();
    }
    public sealed class CounterView { public string key="",name=""; public int amount; }
    public sealed class ManaView { public string color=""; public int id, amount, snowAmount; }
    public sealed class StackView
    {
        public int id, playerId;
        public string text="";
        public bool ability, selectable;
        public CardView? source;
        public TargetView[] targets=System.Array.Empty<TargetView>();
    }
    public sealed class TargetView { public string kind="", name=""; public int id; }
    public sealed class ChoiceView
    {
        public int id, min, max, amount;
        public string title="", kind="";
        public string instructions="";
        public bool optional, repeat;
        public bool cancelCast;
        public CardView[] cards=System.Array.Empty<CardView>();
        public OptionView[] options=System.Array.Empty<OptionView>();

        internal ChoiceView CopyForTable()
        {
            var copy=(ChoiceView)MemberwiseClone();
            copy.cards=System.Array.ConvertAll(cards,card=>card.CopyForTable());
            return copy;
        }
    }
    public sealed class OptionView { public int id, maxAmount, recommendedAmount; public bool disabled; public string label=""; public TargetView? target; }
}
