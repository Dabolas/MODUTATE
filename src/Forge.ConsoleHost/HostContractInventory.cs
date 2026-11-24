using System.Buffers.Binary;
using System.Text;

namespace Planeswalker.ForgeConsole;

public sealed record JavaHostMethod(string Owner,string Name,string Descriptor,int Access,string Direction,bool Abstract);
public static class HostContractInventory
{
    // Metadata reader only; does not execute or load a Java class.
    public static JavaHostMethod[] Read(string file,string direction)
    {
        using var stream=File.OpenRead(file);using var reader=new BinaryReader(stream);
        ushort U2()=>BinaryPrimitives.ReadUInt16BigEndian(reader.ReadBytes(2));
        uint U4()=>BinaryPrimitives.ReadUInt32BigEndian(reader.ReadBytes(4));
        if(U4()!=0xcafebabe)throw new InvalidDataException("Not a class file.");U2();U2();
        var strings=new string?[U2()];var classes=new int[strings.Length];
        for(int i=1;i<strings.Length;i++)
        {
            byte tag=reader.ReadByte();switch(tag)
            {
                case 1:strings[i]=Encoding.UTF8.GetString(reader.ReadBytes(U2()));break;
                case 3:case 4:reader.ReadBytes(4);break;case 5:case 6:reader.ReadBytes(8);i++;break;
                case 7:classes[i]=U2();break;case 8:case 16:case 19:case 20:U2();break;
                case 9:case 10:case 11:case 12:case 17:case 18:U2();U2();break;case 15:reader.ReadByte();U2();break;
                default:throw new InvalidDataException("Unknown class constant tag "+tag);
            }
        }
        void Attributes(){int count=U2();for(int i=0;i<count;i++){U2();stream.Seek(U4(),SeekOrigin.Current);}}
        U2();string owner=strings[classes[U2()]]!;U2();int interfaces=U2();for(int i=0;i<interfaces;i++)U2();
        int fields=U2();for(int i=0;i<fields;i++){U2();U2();U2();Attributes();}
        var result=new List<JavaHostMethod>();int methods=U2();
        for(int i=0;i<methods;i++)
        {int access=U2();string name=strings[U2()]!,descriptor=strings[U2()]!;Attributes();if(!name.StartsWith('<')&&(access&2)==0)result.Add(new(owner,name,descriptor,access,direction,(access&0x400)!=0));}
        return result.ToArray();
    }
    public static string GenerateInterface(IEnumerable<JavaHostMethod> methods)
    {
        var text=new StringBuilder("// Generated complete host callback inventory. Untyped engine values must be converted to seat-filtered HostDecision options.\nnamespace Planeswalker.ForgeConsole;\npublic interface IForgeUiCallbacks\n{\n");
        foreach(var method in methods.Where(m=>m.Direction=="engine-to-host"))
        {
            string digest=Convert.ToHexString(System.Security.Cryptography.SHA256.HashData(Encoding.UTF8.GetBytes(method.Owner+method.Name+method.Descriptor)))[..8];
            text.Append("    // ").Append(method.Owner).Append('.').Append(method.Name).Append(method.Descriptor).Append('\n');
            text.Append("    HostDecision Request_").Append(method.Name.Replace('$','_')).Append('_').Append(digest).Append("(HostDecision seatFilteredRequest);\n");
        }
        return text.Append("}\n").ToString();
    }
}
