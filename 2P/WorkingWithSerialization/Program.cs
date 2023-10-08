using Microsoft.VisualBasic;
using PA17B.Shared;
using System.Xml.Serialization;//Es un objeto que se llama Xml serializer 
using static System.IO.Directory; //Crear o matar carpetas
using static System.IO.Path;// Crear caminos de carpetas (Rutas) URLS
using static System.Environment;
using System.Security.Cryptography;// Que OS tengo, sobre que uso IOS TOY, Permisos del usuario
//Alias


List<Person> people = new()
{

    new(20000M)
    {

        Name = "Gretta",
        LastName = "Medrano",
        DateOfBirth = new(year: 2005, month: 11, day: 5)

    },

    new(30000M)
    {

        Name = "Jared",
        LastName = "Flores",
        DateOfBirth = new(year: 2001, month: 2, day: 15)

    },

    new(40000M)
    {

        Name = "Denahi",
        LastName = "Lopez",
        DateOfBirth = new(year: 2004, month: 6, day: 7)

    },

    new(8000M)
    {

        Name = "Fernando",
        LastName = "Garcia",
        DateOfBirth = new(year: 2005, month: 10, day: 16),
        Children = new()
        {

            new(0M)
            {

                Name = "Marisol",
                LastName = "Garcia",
                DateOfBirth = new(year: 2018, month: 8, day: 9)

            },

            new(0M)
            {

                Name = "Cesar",
                LastName = "Apolinar",
                DateOfBirth = new(year: 2020, month: 7, day: 21)

            }

        }

    }

};

//Serializar: Abstraer un objeto de la vida real a un archivo formateado especificamente

//Dude that speaks XML

XmlSerializer xs = new(type: people.GetType());
string path = Combine(GetCurrentDirectory(), "people.xml");

//3birds 1 stone
//Explicit declaration
using (FileStream stream = File.Create(path))
{

    //Serialize
    //Donde y que mando
    xs.Serialize(stream, people);

}
WriteLine($"Written {new FileInfo(path).Length:N0} bytes of XML on {path}");

//READ
WriteLine(File.ReadAllText(path));

#region De-serialize

WriteLine($"Deserialize XML file");
using (FileStream xmlLoad = File.Open(path, FileMode.Open))
{

    //Deserialize
    List<Person> loadedPeople = xs.Deserialize(xmlLoad) as List<Person>;
    if (loadedPeople is not null)
    {

        foreach (Person p in loadedPeople)
        {

            WriteLine($"{p.Name} has {p.Children.Count} children");

        }

    }

}

#endregion

#region Serialaize Json

string jsonPath = Combine(CurrentDirectory, "people.json");
using (StreamWriter jsonStream = File.CreateText(jsonPath))
{


    Newtonsoft.Json.JsonSerializer jss = new();
    //Serialize
    jss.Serialize(jsonStream, people);

}

WriteLine($"Written {new FileInfo(jsonPath).Length:N0} bytes of XML on {jsonPath}");

WriteLine(File.ReadAllText(jsonPath));

#endregion

#region Deserialize Json

WriteLine("Deserialize Json");
using (FileStream jsonLoad = File.Open(jsonPath, FileMode.Open))
{

    //Deserialize the graph object into a List<Person>
    //Programacion Sincrona: Una accion a la vez
    //Programacion Asincrona: Poner hacer alguien otra cosas mientras otras se esta haciendo
    List<Person>? loadedPeople = await System.Text.Json.JsonSerializer.DeserializeAsync(utf8Json: jsonLoad, returnType: typeof(List<Person>)) as List<Person>;
    if (loadedPeople is not null)
    {

        foreach (Person p in loadedPeople)
        {

            WriteLine($"{p.Name} has {p.Children?.Count} children");

        }

    }

}

/* Solo para metodos async // Tipo Task conoce si suige ejecutandose, termino o fallo

    async Task<string> ReturnName (string a)
    {

        ........
        return await "A" + "B";

    }
  */

#endregion