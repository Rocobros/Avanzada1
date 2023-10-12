using Libraries;
using static System.Console;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;
public class Funciones
{
    public static int MenuLogin()
    {
        int op;
        try
        {
            WriteLine("Seleccione una opcion:");
            WriteLine("1. Log in");
            WriteLine("2. Agregar usuario");
            WriteLine("0. Salir");
            op = Convert.ToInt32(ReadLine());
        }
        catch (System.Exception)
        {
            FormatException error = new(message: "Input was not a number");
            WriteLine(error.Message);
            op = -1;
        }
        return op;

    }

    public static int MenuEquipo()
    {
        int op;
        try
        {
            WriteLine("Selecciona una opcion:");
            WriteLine("1. Agregar equipo");
            WriteLine("2. Modificar equipo");
            WriteLine("3. Eliminar equipo");
            WriteLine("4. Cambiar contrasena");
            WriteLine("5. Generar reporte de equipos");
            WriteLine("0. Salir");
            op = Convert.ToInt32(ReadLine());
        }
        catch (System.Exception)
        {
            FormatException error = new(message: "Input was not a number");
            WriteLine(error.Message);
            op = -1;
        }
        return op;
    }

    public static int MenuReporte()
    {
        int op;
        try
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
            op = Convert.ToInt32(ReadLine());
        }
        catch (System.Exception)
        {
            FormatException error = new(message: "Input was not a number");
            WriteLine(error.Message);
            op = -1;
        }
        return op;
    }
    public static void SerializeCat(List<Equipo> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string pathDigitales = Combine(GetCurrentDirectory(), "digitales.xml");
        string pathAnalogicos = Combine(GetCurrentDirectory(), "analogicos.xml");

        List<Equipo> digitales = new();
        List<Equipo> analogicos = new();

        foreach (Equipo equipo in lista)
        {
            if (equipo.Category.ToLower() == "digital")
            {
                digitales.Add(equipo);
            }
            else if (equipo.Category.ToLower() == "analogico")
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

        string jsonPathDigitales = Combine(GetCurrentDirectory(), "digitales.json");
        string jsonPathAnalogicos = Combine(GetCurrentDirectory(), "analogicos.json");

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
        string path = Combine(GetCurrentDirectory(), "equipos.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, lista);
        }
        string jsonPath = Combine(GetCurrentDirectory(), "equipos.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, lista);
        }
    }

    public static List<Equipo> DeserializeEquipos(List<Equipo> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "equipos.xml");
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
        string path = Combine(GetCurrentDirectory(), "almacenistas.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, lista);
        }

        string jsonPath = Combine(GetCurrentDirectory(), "almacenistas.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, lista);
        }
    }

    public static List<Almacenista> DeserializeAlmacenistas(List<Almacenista> lista)
    {
        XmlSerializer xs = new(type: lista.GetType());
        string path = Combine(GetCurrentDirectory(), "almacenistas.xml");
        List<Almacenista> loaded = new();

        using (FileStream xmlLoad = File.Open(path, FileMode.Open))
        {
            loaded = xs.Deserialize(xmlLoad) as List<Almacenista>;
        }

        return loaded;
    }

    public static void GenerateReport(List<Equipo> lista, int op)
    {

        List<Equipo> reporte = new(lista);

        switch (op)
        {
            case -1:
                WriteLine("Press any key to continue...");
                ReadKey();
                break;
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
        string path = Combine(GetCurrentDirectory(), "reporte.xml");

        using (FileStream stream = File.Create(path))
        {
            xs.Serialize(stream, reporte);
        }
        string jsonPath = Combine(GetCurrentDirectory(), "reporte.json");
        using (StreamWriter jsonStream = File.CreateText(jsonPath))
        {
            Newtonsoft.Json.JsonSerializer jss = new();
            jss.Serialize(jsonStream, reporte);
        }
    }
}