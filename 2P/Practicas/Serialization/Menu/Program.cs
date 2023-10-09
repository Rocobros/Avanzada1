using static System.Console;

using Libraries;


List<Equipo> equipos = new();
List<Almacenista> almacenistas = new();

equipos = DeserializeEquipos(equipos);
almacenistas = DeserializeAlmacenistas(almacenistas);

int op;

//First menu
do
{
    Clear();
    op = MenuLogin();

    switch (op)
    {
        //Login to existing user
        case -1:
            WriteLine("Press any key to continue...");
            ReadKey();
            break;
        case 1:
            Clear();
            WriteLine("Ingresa el ID:");
            string? usuario = ReadLine();
            WriteLine("Ingresa la contrasena:");
            string? pass = ReadLine();

            int currentId = Almacenista.Login(usuario, pass, almacenistas);

            if (currentId != 0)
            {
                //Second menu
                do
                {
                    Clear();
                    op = MenuEquipo();
                    switch (op)
                    {
                        case -1:
                            WriteLine("Press any key to continue...");
                            ReadKey();
                            break;
                        //Agregar usuario
                        case 1:
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

                            equipos.Add(Equipo.Agregar(equipos, modelo, desc, year, marca, cat, inicial, actual));
                            SerializeEquipos(equipos);
                            SerializeCat(equipos);
                            break;
                        //Modificar
                        case 2:
                            WriteLine("Modificar equipo");
                            WriteLine();
                            WriteLine("Ingresa el ID del equipo a modificar:");
                            int id = Convert.ToInt32(ReadLine());

                            foreach(Equipo equipo in equipos)
                            {
                                if(equipo.ID == id)
                                {
                                    string? m = ReadLine();
                                    WriteLine("Ingresa la descripcion:");
                                    string? d = ReadLine();
                                    WriteLine("Ingresa el ano de fabricacion:");
                                    ushort y = Convert.ToUInt16(ReadLine());
                                    WriteLine("Ingresa la marca:");
                                    string? ma = ReadLine();
                                    WriteLine("Ingresa si es Digital o Analogico:");
                                    string? c = ReadLine();
                                    WriteLine("Ingresa su precio inicial:");
                                    decimal i = Convert.ToDecimal(ReadLine());
                                    WriteLine("Ingresa su precio actual:");
                                    decimal a = Convert.ToDecimal(ReadLine());

                                    equipos = Equipo.Modificar(equipos, id, m, d, y, ma, c, i, a);
                                    SerializeEquipos(equipos);
                                    SerializeCat(equipos);
                                }
                            }
                            break;
                        //Borrar
                        case 3:
                            WriteLine("Eliminar equipo");
                            WriteLine();
                            WriteLine("Ingresa la ID del equipo a eliminar:");
                            int identifier = Convert.ToInt32(ReadLine());

                            equipos.Remove(Equipo.Eliminar(equipos, identifier));
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