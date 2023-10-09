using Libraries;
using static System.Console;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
partial class Program
{

    public static void SerializeCat(List<Equipo> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string pathDigitales = Combine(GetCurrentDirectory(), "Files", "XML", "digitales.xml");
        string pathAnalogicos = Combine(GetCurrentDirectory(), "Files", "XML", "analogicos.xml");

        List<Equipo> digitales = new();
        List<Equipo> analogicos = new();

        foreach (Equipo equipo in lista){
            if(equipo.Category.ToLower() == "digital")
            {
                digitales.Add(equipo);
            }
            else if(equipo.Category.ToLower() == "analogico")
            {
                analogicos.Add(equipo);
            }
        }

        using (FileStream stream = File.Create(pathDigitales))
        {
            xs.Serialize(stream, digitales);
        }

        using (FileStream stream = File.Create(pathAnalogicos))
        {
            xs.Serialize(stream, analogicos);
        }
    }
    public static void SerializeEquipos(List<Equipo> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "XML", "equipos.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, lista);
        }
    }

    public static List<Equipo> DeserializeEquipos(List<Equipo> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "XML", "equipos.xml");
        List<Equipo> loaded = new();

        using (FileStream xmlLoad = File.Open(path, FileMode.Open))
        {
            loaded = xs.Deserialize(xmlLoad) as List<Equipo>;
        }

        return loaded;
    }

    public static void SerializeAlmacenistas(List<Almacenista> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "XML", "almacenistas.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, lista);
        }
    }

    public static List<Almacenista> DeserializeAlmacenistas(List<Almacenista> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "XML", "almacenistas.xml");
        List<Almacenista> loaded = new();

        using (FileStream xmlLoad = File.Open(path, FileMode.Open))
        {
            loaded= xs.Deserialize(xmlLoad) as List<Almacenista>;
        }

        return loaded;
    }
}