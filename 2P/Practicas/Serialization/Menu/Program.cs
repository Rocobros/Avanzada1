using static System.Console;
using Libraries;
using System.Xml.Serialization;
using static System.IO.Directory;
using static System.IO.Path;
using static System.Environment;

List<Equipo> equipos = new();
List<Almacenista> almacenistas = new();
Almacenista admin = new("Admin", "Admin", "Admin", 2005, true);
almacenistas.Add(admin);

XmlSerializer xs = new(type: almacenistas.GetType());
string path = Combine(GetCurrentDirectory(), "almacenistas.xml");


int op;
do
{
    Clear();
    WriteLine("Seleccione una opcion:");
    WriteLine("1. Log in");
    WriteLine("2. Agregar usuario");
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
                Clear();
                
            }
            else
            {
                WriteLine("Incorrect credentials");
            }

            break;
        //Creating new user
        case 2:
            Clear();
            WriteLine("Nombre:");
            string? first = ReadLine();
            WriteLine("Apellido:");
            string? last = ReadLine();
            WriteLine("Contrasena:");
            string? contra = ReadLine();
            WriteLine("Ano de nacimiento:");
            string? year = ReadLine();
            Almacenista nuevo = new(first, last, contra, Convert.ToUInt16(year));
            almacenistas.Add(nuevo);

            using (FileStream stream = File.Create(path))
            {
                xs.Serialize(stream, almacenistas);
            }

            break;
        
        default:
            WriteLine("Ingresa un valor aceptable");
            break;
    }

} while (op != 1);