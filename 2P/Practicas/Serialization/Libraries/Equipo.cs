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

    public static Equipo Agregar(List<Equipo> lista, string mod, string des, ushort year, string mar, string cat, decimal ini, decimal act)
    {
        int maxId = 0;
        foreach(Equipo equipo in lista)
        {
            if(equipo.ID > maxId)
            {
                maxId = equipo.ID;
            }
        }

        Equipo nuevo = new(maxId+1, mod, des, year, mar, cat, ini, act);
        return nuevo;
    }

    public static List<Equipo> Modificar(List<Equipo> lista, int id, string mod, string des, ushort year, string mar, string cat, decimal ini, decimal act)
    {
        foreach(Equipo equipo in lista){
            if(equipo.ID == id)
            {
                
            }
        }
        return lista;
    }

    public static Equipo Eliminar(List<Equipo> lista, int id)
    {
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
