using Libraries;
using static System.Console;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
partial class Program
{
    public static void SerializeAlmacenistas(List<Almacenista> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "XML", "almacenistas.xml");

    }
}