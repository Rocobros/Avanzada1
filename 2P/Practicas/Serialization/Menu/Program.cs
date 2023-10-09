using static System.Console;
using Libraries;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

List<Equipo> equipos = new();
List<Almacenista> almacenistas = new();

equipos = DeserializeEquipos(equipos);
almacenistas = DeserializeAlmacenistas(almacenistas);

int op;

//First menu
do
{
    Clear();
    WriteLine("Seleccione una opcion:");
    WriteLine("1. Log in");
    WriteLine("2. Agregar usuario");
    WriteLine("0. Salir");
    op = Convert.ToInt32(ReadLine());

    switch (op)
    {
        
        //Login to existing user
        case 1:
            Clear();
            WriteLine("Ingresa el ID:");
            string? id = ReadLine();
            WriteLine("Ingresa la contrasena:");
            string? pass = ReadLine();

            int currentId = Almacenista.Login(id, pass, almacenistas);

            if (currentId != 0)
            {
                //Second menu
                do
                {
                    Clear();
                    WriteLine("Selecciona una opcion:");
                    WriteLine("1. Agregar equipo");
                    WriteLine("2. Modificar equipo");
                    WriteLine("3. Eliminar equipo");
                    WriteLine("4. Cambiar contrasena");
                    WriteLine("5. Generar reporte de equipos");
                    WriteLine("0. Salir");
                    op = Convert.ToInt32(ReadLine());

                    Clear();
                    switch (op)
                    {
                        //Agregar usuario
                        case 1:
                            equipos.Add(Equipo.Agregar(equipos));
                            SerializeEquipos(equipos);
                            SerializeCat(equipos);
                            break;
                        //Modificar
                        case 2:
                            equipos = Equipo.Modificar(equipos);
                            SerializeEquipos(equipos);
                            SerializeCat(equipos);
                            break;
                        //Borrar
                        case 3:
                            equipos.Remove(Equipo.Eliminar(equipos));
                            SerializeEquipos(equipos);
                            SerializeCat(equipos);
                            break;
                        //Cambiar contra
                        case 4:
                            almacenistas = Almacenista.CambiarContra(almacenistas);
                            SerializeAlmacenistas(almacenistas);
                            break;
                        //Generar reporte
                        case 5:
                            GenerateReport(equipos);
                            break;
                        //Salir
                        case 0:
                            WriteLine("Saliendo...");
                            break;
                        //Otro
                        default:
                            WriteLine("Opcion no especificada");
                            WriteLine("Press any key to continue...");
                            ReadKey();
                            break;
                    }

                } while (op != 0);
                
            }
            else
            {
                WriteLine("Incorrect credentials");
                WriteLine("Press any key to continue...");
                ReadKey();
            }

            break;
        //Creating new user
        case 2:
            Clear();
            almacenistas.Add(Almacenista.Agregar(almacenistas));

            SerializeAlmacenistas(almacenistas);

            break;
        case 0:
            Clear();
            WriteLine("Saliendo...");
            break;
        default:
            WriteLine("Opcion no especificada");
            WriteLine("Press any key to continue...");
            ReadKey();
            break;
    }

} while (op != 0);