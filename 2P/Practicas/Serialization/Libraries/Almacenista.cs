using static System.Console;
using System.Xml.Serialization;
using System.Diagnostics.Contracts;

namespace Libraries;

public class Almacenista
{
    public Almacenista(){

    }
    public Almacenista(int id, string first, string last, string pass, ushort year, bool admin)
    {
        this.ID = id;
        this.FirstName = first;
        this.LastName = last;
        this.Password = pass;
        this.YearOfBirth = year;
        this.Admin = admin;
    }
    public Almacenista(int id, string first, string last, string pass, ushort year)
    {
        this.ID = id;
        this.FirstName = first;
        this.LastName = last;
        this.Password = pass;
        this.YearOfBirth = year;
        this.Admin = false;
    }
    
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
            if(user.ID==Convert.ToInt32(id) && EncriptionMD5.Decrypt(user.Password).Equals(pass))
            {
                return user.ID;
            }
        }
        return 0;
    }
    
    public static Almacenista Agregar(List<Almacenista> lista)
    {

        WriteLine("Nombre:");
        string? first = ReadLine();
        WriteLine("Apellido:");
        string? last = ReadLine();
        WriteLine("Contrasena:");
        string? pass = ReadLine();
        WriteLine("Ano de nacimiento:");
        ushort year = Convert.ToUInt16(ReadLine());

        int maxId = 0;
        foreach (Almacenista almacenista in lista)
        {
            if (almacenista.ID > maxId)
            {
                maxId = almacenista.ID;
            }
        }

        string firstEncripted = EncriptionMD5.Encrypt(first);
        string lastEncripted = EncriptionMD5.Encrypt(last);
        string passEncripted = EncriptionMD5.Encrypt(pass);

        Almacenista nuevo = new(maxId+1, firstEncripted, lastEncripted, passEncripted, year);
        return nuevo;
    }

    public static List<Almacenista> CambiarContra(List<Almacenista> lista)
    {
        WriteLine("Cambiar contrasena:");
        WriteLine();
        WriteLine("Ingresa el ID del almacenista:");
        int id = Convert.ToInt32(ReadLine());

        foreach (Almacenista almacenista in lista)
        {
            if(almacenista.ID == id)
            {
                WriteLine();
                WriteLine("Ingresa la nueva contrasena:");
                string? nueva = ReadLine();
                almacenista.Password = nueva;
            }
        }
        return lista;
    }
}