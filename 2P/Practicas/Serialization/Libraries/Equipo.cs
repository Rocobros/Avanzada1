using System.Xml.Serialization;
using static System.Console;
namespace Libraries;

public class Equipo
{
    public Equipo()
    {

    }
    public Equipo(int id, string model, string desc, ushort year, string brand, string category, decimal initial, decimal current)
    {
        ID = id;
        Model = model;
        Description = desc;
        Year = year;
        Brand = brand;
        Category = category;
        InitalPrice = initial;
        CurrentPrice = current;
}

    [XmlAttribute("ID")]
    public int ID {get; set;}
    public string? Model {get; set;}
    public string? Description {get; set;}
    public ushort Year {get; set;}
    public string? Brand {get; set;}
    public string? Category {get; set;}
    public decimal InitalPrice {get; set;}
    public decimal CurrentPrice {get; set;}

    public static Equipo Agregar(List<Equipo> lista)
    {
        WriteLine("Agregar nuevo equipo");
        WriteLine();
        WriteLine("Ingresa el modelo:");
        string? modelo = ReadLine();
        WriteLine("Ingresa la descripcion:");
        string? desc = ReadLine();
        WriteLine("Ingresa el ano de fabricacion:");
        ushort year = Convert.ToUInt16(ReadLine());
        WriteLine("Ingresa la marca:");
        string? marca = ReadLine();
        WriteLine("Ingresa si es Digital o Analogico:");
        string? cat = ReadLine();
        WriteLine("Ingresa su precio inicial:");
        decimal inicial = Convert.ToDecimal(ReadLine());
        WriteLine("Ingresa su precio actual:");
        decimal actual = Convert.ToDecimal(ReadLine());


        int maxId = 0;
        foreach(Equipo equipo in lista)
        {
            if(equipo.ID > maxId)
            {
                maxId = equipo.ID;
            }
        }

        Equipo nuevo = new(maxId+1, modelo, desc, year, marca, cat, inicial, actual);
        return nuevo;
    }

    public static List<Equipo> Modificar(List<Equipo> lista)
    {
        WriteLine("Modificar equipo");
        WriteLine();
        WriteLine("Ingresa el ID del equipo a modificar:");
        int id = Convert.ToInt32(ReadLine());

        foreach(Equipo equipo in lista){
            if(equipo.ID == id)
            {
                WriteLine("Ingresa el modelo:");
                equipo.Model = ReadLine();
                WriteLine("Ingresa la descripcion:");
                equipo.Description = ReadLine();
                WriteLine("Ingresa el ano de fabricacion:");
                equipo.Year = Convert.ToUInt16(ReadLine());
                WriteLine("Ingresa la marca:");
                equipo.Brand = ReadLine();
                WriteLine("Ingresa si es Digital o Analogico:");
                equipo.Category = ReadLine();
                WriteLine("Ingresa su precio inicial:");
                equipo.InitalPrice = Convert.ToDecimal(ReadLine());
                WriteLine("Ingresa su precio actual:");
                equipo.CurrentPrice = Convert.ToDecimal(ReadLine());
            }
        }
        return lista;
    }

    public static Equipo Eliminar(List<Equipo> lista)
    {
        WriteLine("Eliminar equipo");
        WriteLine();
        WriteLine("Ingresa la ID del equipo a eliminar:");
        int id = Convert.ToInt32(ReadLine());
        Equipo nuevo = new();
        foreach(Equipo equipo in lista)
        {
            if(equipo.ID == id)
            {
                nuevo = equipo;
            }
        }
        return nuevo;
    }

    public static int CompareByID(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.ID.CompareTo(equipo2.ID);
    }
    public static int CompareByModel(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Model.CompareTo(equipo2.Model);
    }
    public static int CompareByDesc(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Description.CompareTo(equipo2.Description);
    }
    public static int CompareByYear(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Year.CompareTo(equipo2.Year);
    }
    public static int CompareByBrand(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Brand.CompareTo(equipo2.Brand);
    }
    public static int CompareByCategory(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Category.CompareTo(equipo2.Category);
    }
    public static int CompareByInitial(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.InitalPrice.CompareTo(equipo2.InitalPrice);
    }
    public static int CompareByCurrent(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.CurrentPrice.CompareTo(equipo2.CurrentPrice);
    }
}
