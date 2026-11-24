# MODUTATE notices

## Forge and the managed port

Forge is copyright its original authors and contributors.

- Upstream project [Card-Forge/forge](https://github.com/Card-Forge/forge)
- Corresponding Java source at [`f818e4b2751a8237c5e1ba35248f6373745217aa`](https://github.com/Card-Forge/forge/tree/f818e4b2751a8237c5e1ba35248f6373745217aa)
- Upstream license [GNU GPL version 3](https://github.com/Card-Forge/forge/blob/f818e4b2751a8237c5e1ba35248f6373745217aa/LICENSE)

**Modification notice, 2026-11-24.** Dabolas adapted the Forge rule engine for managed C# execution. Changes include Java method translation, Java runtime and standard library adapters, card database loading, headless decisions and state projection, and integration for rule evaluation and automated players. The generated C# in this tree is the implementation used to build the managed rules library. The upstream Java input is the pinned, unmodified revision.

The managed rules work is available under the GNU General Public License, version 3 or any later version. See [LICENSE](LICENSE). Original notices remain in force, including applicable grants covering later GPL versions.

## Unicode data

The files in [`src/Forge.Aot/Unicode13`](src/Forge.Aot/Unicode13) contain Unicode 13.0.0 character database data. Unicode, Inc. holds the original copyrights. The data retain their upstream notices where supplied. The accompanying [Unicode data license](LICENSES/Unicode-DFS-2016.txt) applies to those resources.

## Json.NET

The host references [Json.NET 13.0.2](https://github.com/JamesNK/Newtonsoft.Json/tree/13.0.2) from NuGet under the [MIT license](LICENSES/Newtonsoft.Json.txt).
