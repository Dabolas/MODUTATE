using Planeswalker.ForgeAot;
using Planeswalker.ForgeAot.Generated;

namespace Planeswalker.TableHost;

internal static class TableProgram
{
    static readonly Lazy<JProgram> definitions=new(ForgeProgram.BuildForDevelopment);
    public static JProgram Open()=>definitions.Value.Fork();
}
