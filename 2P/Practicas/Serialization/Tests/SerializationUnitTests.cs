namespace Tests;
using Libraries;

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
    public void FormatExceptionTest()
    {
        
    }
}