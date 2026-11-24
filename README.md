# MODUTATE

MODUTATE 是 Dabolas 基于 [Card-Forge/Forge](https://github.com/Card-Forge/forge) 移植的 C# 卡牌规则引擎。仓库包含规则运行时、已转译的 C#、规则数据、无界面对局宿主和转译工具。

MODUTATE is a managed card rules engine adapted from Card-Forge by Dabolas. The core runs under .NET and the headless host exposes game state and player decisions to a caller.

## 构建

安装 [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)，在仓库根目录运行以下命令。宿主项目会从 NuGet 获取 Newtonsoft.Json 13.0.2。

```powershell
dotnet build src/Forge.TableHost/Forge.TableHost.csproj -c Release
dotnet run --project tests/ForgeIgnition/ForgeIgnition.csproj -c Release -- --minimum-turn
```

规则宿主的目标框架为 .NET Standard 2.1。构建使用仓库内的 C# 和规则数据。上游 Java 项目与翻译工具链用于重新生成转译源码。

## 源码与上游

| 路径 | 内容 |
| --- | --- |
| `src/Forge.Aot` | C# 运行时与标准库适配 |
| `migration/forge-aot` | 对应当前引擎的生成 C#、输入记录和构建配置 |
| `src/Forge.TableHost` | 无界面对局、规则输入输出、机器人操作和状态投影 |
| `src/Forge.ConsoleHost` | 牌库索引和规则数据加载 |
| `data/forge` | 规则脚本、衍生物和相关注册数据 |
| `tools` | 上游规则数据导入与 Java 到 C# 的转译工具 |

上游固定在 [`f818e4b2751a8237c5e1ba35248f6373745217aa`](https://github.com/Card-Forge/forge/commit/f818e4b2751a8237c5e1ba35248f6373745217aa)。需要研究或重新生成转译输入时，从该提交获取 Forge Java 源码。Java 和 Maven 版本记录在 [`bridge/toolchain.lock.json`](bridge/toolchain.lock.json)。

```powershell
git clone https://github.com/Card-Forge/forge.git external/forge
git -C external/forge checkout --detach f818e4b2751a8237c5e1ba35248f6373745217aa
mvn -f external/forge/pom.xml -pl forge-game -am -DskipTests compile
python tools/import_full_forge.py --forge external/forge
node tools/build-table-index.mjs
python tools/build_forge_aot.py --modules forge-core forge-game
```

## 许可证

规则引擎按 GNU GPL 第 3 版或其后续版本发布。Forge 原作者的版权与许可声明继续适用。完整条款见 [LICENSE](LICENSE)，移植说明和第三方数据声明见 [NOTICE.md](NOTICE.md)。
