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

        prev.Add(new Equipo(id, modelo, desc, year, marca, cat, inicial, actual));

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
}