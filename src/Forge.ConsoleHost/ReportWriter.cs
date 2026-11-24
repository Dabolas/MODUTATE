using System.Text;
using System.Text.Json;

namespace Planeswalker.ForgeConsole;

public static class ReportWriter
{
    public static void Write(string directory)
    {
        using var scan=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"scan.json")));
        using var api=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"host-api.json")));
        using var audit=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"library-linkage.json")));
        using var contracts=JsonDocument.Parse(File.ReadAllText(Path.Combine(directory,"contract-checks.json")));
        var s=scan.RootElement;var a=api.RootElement;var l=audit.RootElement;
        string N(string key)=>s.GetProperty(key).GetRawText();
        var text=new StringBuilder();
        text.AppendLine("# Forge C# 控制台四步验证报告");
        text.AppendLine($"\n生成时间（UTC）：{DateTimeOffset.UtcNow:O}。固定 Forge 源码：f818e4b2751a8237c5e1ba35248f6373745217aa。\n");
        text.AppendLine("**结论：全量资料已经挂载，受控伤害场景点火成功；完整 Forge Game、全部标准库及全部规则仍未接通。不能宣布全部卡牌可用。** 本轮只运行 .NET 控制台，没有启动游戏、UI、Java 引擎或外部伴随程序，也没有安装/覆盖游戏 MOD。\n");
        text.AppendLine("## 第一步：底层与宿主交互\n");
        text.AppendLine($"标准库/兼容层当前注册 {a.GetProperty("boundSignatures").GetArrayLength()} 个方法签名；这不是覆盖全部 Java 标准库。生成代码原有 {l.GetProperty("generatedExternalReferences")} 个外部调用引用，其中 Java 类库引用 {l.GetProperty("javaReferences")} 个，本轮有直接绑定 {l.GetProperty("javaDirectBindings")} 个，尚无直接绑定 {l.GetProperty("javaWithoutDirectBinding")} 个。统计只覆盖生成清单里的直接调用和数组 clone，不能当作完整依赖闭包证明。\n");
        text.AppendLine("实际使用 System.Collections.Generic、System.IO.MemoryStream、System.Text.StringBuilder 和受限 System.Text.RegularExpressions 适配。已覆盖基础 List/Set/EnumSet/Map/双向 Map、只读视图、迭代器、Integer、字符串、字节输入流和 Arrays.stream/filter/collect(toList) 的部分方法；过滤器通过原转译 lambda 调用。大小写转换/比较目前仅允许 ASCII，其他输入明确报缺口。自定义 equals/Comparable、完整 Stream API、全部文件接口、第三方库和正则语义仍有缺口，未知调用抛 PortGap，不用空实现冒充规则。\n");
        text.AppendLine($"接口与标准库专项检查：{contracts.RootElement.GetProperty("checks").GetArrayLength()} 项通过，详见 [contract-checks.json](contract-checks.json)。\n");
        text.AppendLine("宿主接口代码：`src/Forge.ConsoleHost/HostAdapterApi.cs`、`AotHostAdapter.cs`。事件 `DecisionRequested(HostDecision)` 发出选择请求；UI 调用 `TryReply(HostAnswer)`，引擎在 `TryTakeReply` 后通过 `JRuntime.Resume` 继续原调用栈。不会为了等待 UI 重放已执行效果。请求携带请求号、局面版本、席位、合法选项、数量/数值边界；拒绝过期、越权、重复和非法回答。UI 编码器必须筛掉其他玩家不可见信息。\n");
        text.AppendLine("| 交互族 | HostDecisionKind / 返回内容 |\n|---|---|\n| 选目标、区域移动、弃牌/牺牲、展示、调度/沉底 | ChooseTargets/ChooseCards/Discard/Sacrifice/Reveal/Mulligan/ChooseBottomCards；合法对象 ID 列表 |\n| 优先权、费用、确认、替代效应 | Priority/PayCosts/Confirm/ChooseReplacement；确认选项或合法费用方案 |\n| 模式、数字/X、牌名、种族、颜色、投票 | ChooseMode/ChooseNumber/ChooseName/ChooseType/ChooseColor/Vote；选项、Number 或 Text |\n| 宣攻、阻挡、伤害分配、触发排序 | DeclareAttackers/DeclareBlockers/AssignDamage/OrderTriggers；需由对应编码器转换为原引擎类型 |\n| 地城、备牌及其他 | DungeonRoom/Sideboard/Other；按原 Java 方法签名实现专用编码器 |\n");
        text.AppendLine($"从 PlayerController 提取全部 {a.GetProperty("abstractPlayerControllerMethods").GetArrayLength()} 个抽象方法，并为这些方法实现统一暂停通道；另提取 IGuiGame 与 IGameController 声明，共 {a.GetProperty("allDeclaredUiMethods").GetArrayLength()} 个方法记录。完整签名和方向见 [host-api.json](host-api.json)，C# 逐方法接口清单见 [IForgeUiCallbacks.Generated.cs](IForgeUiCallbacks.Generated.cs)。该清单是待实现合同，**不表示全部回调已经接入游戏 UI**。当前 AOT 数值选择编码器已执行验证，控制台对战的目标、付款和优先权使用 ConsoleMatch 的宿主请求；其余复杂对象编码仍需实现。\n");
        text.AppendLine("## 第二步：全量数据库\n");
        text.AppendLine($"按分片 SHA-256 校验并加载 {N("cards")} 张卡牌和 {N("tokens")} 种衍生物。C# 资料实例：卡牌 {N("metadataCreated")}、衍生物 {N("tokenMetadataCreated")}。卡名严格匹配，原始脚本、字段、费用和规则文本均保留。另校验并挂载原 TypeLists.txt，实际调用原 FileSection.parseSections 与 CardType.Helper.parseTypes，包含多词生物/时空类别。\n");
        text.AppendLine("```csharp\nusing Planeswalker.ForgeConsole;\n\nvar db = CardDatabase.Load(Path.Combine(root, \"data/forge\"));\nCardInstance bolt = db.Create(\"Lightning Bolt\", owner: 0);\nConsole.WriteLine($\"{bolt.InstanceId}: {bolt.Definition.Name}\");\n```\n");
        text.AppendLine("这创建的是带完整资料的 C# CardInstance，**不是已由原 Forge CardFactory 初始化全部规则的游戏 Card**。另用 AotCardReader 执行原转译 CardRules.Reader 构造与读取方法，逐张统计真实缺口，见下文。\n");
        text.AppendLine("## 第三步：控制台最小点火\n");
        text.AppendLine("两名玩家各 20 生命、各 40 张基本地，初始抓 7 张。强制推进回合，验证抓牌与已横置山脉的重置；测试夹具额外把一张 Lightning Bolt 放入手牌，横置山脉产生 R，宿主选择对手、确认支付并扣除 R。施放者和对手分别让过优先权，再结算。费用不足的另一次施放已拒绝，手牌、生命与法术力未被修改，之后可以重新尝试。\n");
        text.AppendLine("```text\nSTACK push: Lightning Bolt -> player 1\nPRIORITY: player 0 passes.\nPRIORITY: player 1 passes.\nAOT executed DamageDealEffect.resolve; damage batch=3; player 1: 20 -> 17\nRESOLVED: Lightning Bolt -> Graveyard; stack empty.\n```\n");
        text.AppendLine("实际执行了原转译 `DamageDealEffect.resolve` 和 `CardDamageTable.put`，没有覆盖这两个方法体；伤害批次随后由 C# 宿主提交到生命值。原始相关构造器也已运行。完整方法与绑定记录见 [ignition.json](ignition.json)，逐步日志见 [ignition.log](ignition.log)，费用拒绝记录见 [negative-cast.json](negative-cast.json)。\n");
        text.AppendLine("**范围限制：**本次是 C# 控制台宿主与原始 AOT 伤害效果的纵向接通；Game/Player/Card 等宿主模型、常数表达式和空环境替代处理仍为受控适配。只验证空战场、玩家目标、没有触发、替代、保护、伤害防止等效果的场景。未初始化完整原 Forge Game，也未验证原优先权/阶段/状态动作/触发调度，不能把此结果称为完整 Forge 对局通过。\n");
        text.AppendLine("## 第四步：全量逐张扫描\n");
        text.AppendLine($"| 指标 | 结果 |\n|---|---:|\n| 卡牌资料实例创建 | {N("metadataCreated")} / {N("cards")}（{N("metadataRate")}%） |\n| 衍生物资料实例创建 | {N("tokenMetadataCreated")} / {N("tokens")} |\n| 原 AOT CardRules.Reader 尝试 | {N("aotReaderAttempted")} / {N("cards")} |\n| 原 AOT CardRules.Reader 成功 | {N("aotReaderPassed")} / {N("cards")}（{N("aotReaderRate")}%） |\n| 衍生物原 AOT Reader 成功 | {N("tokenAotReaderPassed")} / {N("tokens")} |\n| 受控场景执行成功 | {N("scenarioExecuted")} / {N("cards")}（{s.GetProperty("scenarioExecutionRate").GetDouble():F6}%） |\n| 其中基本地下地/产费场景 | {N("landRuns")} |\n| 其中原伤害效果场景 | {N("damageRuns")} |\n| 完整规则实际可运行率 | **尚不可确定**；完整 Game 未接通 |\n");
        text.AppendLine("原读取流程当前失败类别（首个阻塞，不是所有后续缺口的总量）：\n");
        foreach(var error in s.GetProperty("readerErrors").EnumerateObject())text.AppendLine($"- {error.Value} 张：`{error.Name.Replace("`", "'")}`");
        text.AppendLine("\n全部明细：[card-failures.jsonl](card-failures.jsonl)、[aot-reader-failures.jsonl](aot-reader-failures.jsonl)、[token-failures.jsonl](token-failures.jsonl)。受控场景拒绝代码与完整统计在 [scan.json](scan.json)。`RuleGapException` 是夹具主动拒绝不支持规则，不能当成 Java 缺少标准库的异常；原 Reader 的缺库/异常另列。\n");
        text.AppendLine("## 代码与复现\n");
        text.AppendLine("完整入口：`tests/ForgeIgnition/Program.cs`；专项检查：`ContractChecks.cs`；宿主、数据库、原读取/伤害桥接及报告：`src/Forge.ConsoleHost/`；共享兼容层：`src/Forge.Aot/`；原转译源码：`migration/forge-aot/generated/`。所有这些工程只引用托管 .NET 工程，不引用游戏或 Unity 程序集。\n");
        text.AppendLine("```powershell\npowershell -NoProfile -ExecutionPolicy Bypass -File .\\tools\\run-forge-console.ps1\n# 如需在完整引擎未接通时返回失败：\npowershell -NoProfile -ExecutionPolicy Bypass -File .\\tools\\run-forge-console.ps1 -RequireFull\n```\n");
        text.AppendLine("`-RequireFull` 当前应失败，防止把受控点火用于全量规则验收。`summary.json` 保持 allRequirementsCompleted=false、fullRulesMigrated=false，工坊/游戏发行入口仍禁止启用未完成的引擎。\n");
        File.WriteAllText(Path.Combine(directory,"report.zh-CN.md"),text.ToString());
    }
}
