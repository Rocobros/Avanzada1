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

        string jsonPathDigitales = Combine(GetCurrentDirectory(), "Files", "JSON", "digitales.json");
        string jsonPathAnalogicos = Combine(GetCurrentDirectory(), "Files", "JSON", "analogicos.json");

        using (StreamWriter jsonStream = File.CreateText(jsonPathDigitales))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, digitales);

        }

        using (StreamWriter jsonStream = File.CreateText(jsonPathAnalogicos))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, analogicos);
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
        string jsonPath = Combine(GetCurrentDirectory(), "Files", "JSON", "equipos.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, lista);
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

        string jsonPath = Combine(GetCurrentDirectory(), "Files", "JSON", "almacenistas.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, lista);
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

    public static void GenerateReport(List<Equipo> lista)
    {
        WriteLine("Generar reporte");
        WriteLine();
        WriteLine("Por que valor quieres ordenar?");
        WriteLine("1. Id");
        WriteLine("2. Modelo");
        WriteLine("3. Descripcion");
        WriteLine("4. Ano");
        WriteLine("5. Marca");
        WriteLine("6. Categoria");
        WriteLine("7. Precio inicial");
        WriteLine("8. Precio actual");
        int op = Convert.ToInt32(ReadLine());
        List<Equipo> reporte = new(lista);

        switch (op)
        {
            case 1:
                reporte.Sort(Equipo.CompareByID);
                break;
            case 2:
                reporte.Sort(Equipo.CompareByModel);
                break;
            case 3:
                reporte.Sort(Equipo.CompareByDesc);
                break;
            case 4:
                reporte.Sort(Equipo.CompareByYear);
                break;
            case 5:
                reporte.Sort(Equipo.CompareByBrand);
                break;
            case 6:
                reporte.Sort(Equipo.CompareByCategory);
                break;
            case 7:
                reporte.Sort(Equipo.CompareByInitial);
                break;
            case 8:
                reporte.Sort(Equipo.CompareByCurrent);
                break;
            default:
                WriteLine("Opcion invalida");
                break;
        }

        XmlSerializer xs = new(type: reporte.GetType());
        string path = Combine(GetCurrentDirectory(), "Files", "Reporte", "reporte.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, reporte);
        }
        string jsonPath = Combine(GetCurrentDirectory(), "Files", "Reporte", "reporte.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, reporte);
        }
    }
}