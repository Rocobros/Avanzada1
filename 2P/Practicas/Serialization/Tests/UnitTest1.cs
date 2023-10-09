namespace Tests;
using Libraries;

public class SerializationUnitTests
{
    [Fact]
    public void AgregarEquipoTest()
    {
        List<Equipo> prev = new();
        prev = Funciones.DeserializeEquipos(prev);

        
    }
}