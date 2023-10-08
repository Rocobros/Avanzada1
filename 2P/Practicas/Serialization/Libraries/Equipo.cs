using System.Xml.Serialization;

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
    [XmlAttribute("Model")]
    public string? Model {get; set;}
    public string? Description {get; set;}
    public ushort Year {get; set;}
    public string? Brand {get; set;}
    public string? Category {get; set;}
    public decimal InitalPrice {get; set;}
    public decimal CurrentPrice {get; set;}

    public static int CompareByYear(Equipo equipo1, Equipo equipo2)
    {
        return equipo1.Year.CompareTo(equipo2.Year);
    }
}
