namespace Tests;

using Libraries;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

public class SerializationUnitTests
{

    
    [Fact]
    public void AgregarEquipoTest()
    {
        List<Equipo> prev = new();

        int id = -1;
        string modelo = "example";
        string desc = "example";
        ushort year = 0;
        string marca = "example";
        string cat = "example";
        decimal inicial = 0M;
        decimal actual = 0M;

        prev.Add(Equipo.Agregar(id, modelo, desc, year, marca, cat, inicial, actual));

        bool res = false;
        foreach (Equipo equipo in prev)
        {
            if (equipo.ID == id)
            {
                res = true;
            }
        }
        Assert.True(res);
    }
    [Fact]
    public void ModificarEquipoTest()
    {
        List<Equipo> prev = new();
        int id = -1;
        string modelo = "example";
        string desc = "example";
        ushort year = 0;
        string marca = "example";
        string cat = "example";
        decimal inicial = 0M;
        decimal actual = 0M;

        prev.Add(Equipo.Agregar(id, modelo, desc, year, marca, cat, inicial, actual));

        bool res = false;
        foreach (Equipo equipo in prev)
        {
            if (equipo.ID == id)
            {
                if( equipo.Model == modelo &&
                    equipo.Description == desc &&
                    equipo.Year == year &&
                    equipo.Brand == marca &&
                    equipo.Category == cat &&
                    equipo.InitalPrice == inicial &&
                    equipo.CurrentPrice == actual)
                {
                    res = true;
                }
            }
        }
        Assert.True(res);
    }
    [Fact]
    public void EliminarEquipoTest()
    {
        List<Equipo> prev = new();
        int id = -1;
        string modelo = "example";
        string desc = "example";
        ushort year = 0;
        string marca = "example";
        string cat = "example";
        decimal inicial = 0M;
        decimal actual = 0M;

        prev.Add(Equipo.Agregar(id, modelo, desc, year, marca, cat, inicial, actual));

        prev.Remove(Equipo.Eliminar(prev, id));
        bool res = true;
        foreach (Equipo equipo in prev)
        {
            if (equipo.ID == id)
            {
                res = false;
            }
        }
        Assert.True(res);
    }
    [Fact]
    public void ContraEncriptadaTest()
    {
        List<Almacenista> prev = new();
        int id = -1;
        string first = "first";
        string last = "last";
        string pass = "pass";
        ushort year = 1000;

        prev.Add(Almacenista.Agregar(id, first, last, pass, year));

        bool res = false;
        foreach(Almacenista almacenista in prev)
        {
            if(almacenista.ID == id){
                if(EncriptionMD5.Decrypt(almacenista.Password) == pass)
                {
                    res = true;
                }
            }
        }
        Assert.True(res);
    }
    [Fact]
    public void CambiarContraAlmacenistaTest()
    {
        List<Almacenista> prev = new();
        int id = -1;
        string first = "first";
        string last = "last";
        string pass = "pass";
        ushort year = 1000;

        prev.Add(Almacenista.Agregar(id, first, last, pass, year));

        string newPass = "nueva";
        prev = Almacenista.CambiarContra(prev, id, newPass);

        bool res = false;
        foreach(Almacenista almacenista in prev)
        {
            if(almacenista.ID == id)
            {
                if(almacenista.Password == EncriptionMD5.Encrypt(newPass))
                {
                    res = true;
                }
            }
        }
        Assert.True(res);
    }
    [Fact]
    public void EncriptarTest()
    {
        string text = "Hola Mundo";
        string encriptado = EncriptionMD5.Encrypt(text);

        bool res = false;
        if(text == EncriptionMD5.Decrypt(encriptado))
        {
            res = true;
        }
        Assert.True(res);
    }
    [Fact]
    public void DesencriptarTest()
    {
        string text = "Hola Mundo";
        string encriptado = EncriptionMD5.Encrypt(text);
        

        bool res = false;
        if (EncriptionMD5.Decrypt(encriptado) == text)
        {
            res = true;
        }
        Assert.True(res);
    }
    [Fact]
    public void GenerarEquiposFiles()
    {
        List<Equipo> prev = new();
        int id = -1;
        string modelo = "example";
        string desc = "example";
        ushort year = 0;
        string marca = "example";
        string cat = "example";
        decimal inicial = 0M;
        decimal actual = 0M;

        prev.Add(Equipo.Agregar(id, modelo, desc, year, marca, cat, inicial, actual));


        Funciones.SerializeEquipos(prev);
        string path = Combine(GetCurrentDirectory(), "equipos.xml");
        string jsonPath = Combine(GetCurrentDirectory(), "equipos.json");
        
        bool res = false;
        if(Path.Exists(path) && Path.Exists(jsonPath))
        {
            res = true;
        }
        Assert.True(res);
    }
    [Fact]
    public void GenerarAlmacenistaFiles()
    {
        List<Almacenista> prev = new();
        int id = -1;
        string first = "first";
        string last = "last";
        string pass = "pass";
        ushort year = 1000;

        prev.Add(Almacenista.Agregar(id, first, last, pass, year));

        Funciones.SerializeAlmacenistas(prev);
        string path = Combine(GetCurrentDirectory(), "almacenistas.xml");
        string jsonPath = Combine(GetCurrentDirectory(), "almacenistas.json");
        
        bool res = false;
        if(Path.Exists(path) && Path.Exists(jsonPath))
        {
            res = true;
        }
        Assert.True(res);
    }
    [Fact]
    public void GenerarReporte()
    {
        List<Equipo> prev = new();
        int id = 1;
        string modelo = "A12";
        string desc = "example";
        ushort year = 2020;
        string marca = "Steren";
        string cat = "Digital";
        decimal inicial = 100M;
        decimal actual = 150M;

        int id2 = 2;
        string modelo2 = "b13";
        string desc2 = "example";
        ushort year2 = 2011;
        string marca2 = "HP";
        string cat2 = "Analogico";
        decimal inicial2 = 150M;
        decimal actual2 = 100M;

        prev.Add(Equipo.Agregar(id, modelo, desc, year, marca, cat, inicial, actual));
        prev.Add(Equipo.Agregar(id2, modelo2, desc2, year2, marca2, cat2, inicial2, actual2));

        Funciones.GenerateReport(prev, 4);
        string path = Combine(GetCurrentDirectory(), "reporte.xml");
        string jsonPath = Combine(GetCurrentDirectory(), "reporte.json");

        bool res = false;
        if(Path.Exists(path) && Path.Exists(jsonPath))
        {
            res = true;
        }
        Assert.True(res);
    }
}