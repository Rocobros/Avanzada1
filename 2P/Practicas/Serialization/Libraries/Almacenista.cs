using System.ComponentModel;
using System.Xml.Serialization;

namespace Libraries;

public class Almacenista
{
    public Almacenista(){

    }

    public Almacenista(string first, string last, string pass, ushort year, bool admin){
        this.ID = CurrentID;
        this.FirstName = first;
        this.LastName = last;
        this.Password = pass;
        this.YearOfBirth = year;
        this.Admin = admin;
        CurrentID++;
    }
    public Almacenista(string first, string last, string pass, ushort year)
    {
        this.ID = CurrentID;
        this.FirstName = first;
        this.LastName = last;
        this.Password = pass;
        this.YearOfBirth = year;
        this.Admin = false;
        CurrentID++;
    }
    
    static int CurrentID = 1;
    [XmlAttribute("ID")]
    public int ID { get; set; }
    [XmlAttribute("FName")]
    public string? FirstName { get; set; }
    [XmlAttribute("LName")]
    public string? LastName { get; set; }
    public string? Password { get; set; }
    public ushort YearOfBirth { get; set; }
    public bool Admin { get; set; }

    public static int Login(string? id, string? pass, List<Almacenista> lista)
    {
        foreach(Almacenista user in lista)
        {
            if(user.ID==Convert.ToInt32(id) && user.Password.Equals(pass))
            {
                return user.ID;
            }
        }
        return 0;
    }
    
}