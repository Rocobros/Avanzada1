
List<List<string>> uso;
//Llamar el leer con la Lista de Listas uso
uso = Leer();

//Crear un File con un Writer para escribir dentro del archivo
StreamWriter textWriter = File.CreateText("Copy.txt");


foreach(var linea in uso)
{

    double valor1;
    double valor2;
    
    string respuesta = "res= ";

    if(linea.Count == 3)
    {

        //Saber si existe alguna fraccion en la operacion
        if(linea[0].Contains('/') || linea[2].Contains('/'))
        {
            
            //Mandar a llamar si hay alguna fraccion
            respuesta = Fracciones(linea[0],linea[2],linea[1]);

        }
        else
        {
            //Sino hay ninguna fraccion

            valor1 = double.Parse(linea[0]);
            valor2 = double.Parse(linea[2]);

            //Opciones con el operador
            if(linea[1] == "+")
            {

                respuesta += Convert.ToString(Suma(valor1,valor2));

            }
            else if(linea[1] == "-")
            {

                respuesta += Convert.ToString(Resta(valor1,valor2));

            }
            else if(linea[1] == "*")
            {

                respuesta += Convert.ToString(Multiplicacion(valor1,valor2));

            }
            else if(linea[1] == "/")
            {

                respuesta += Convert.ToString(Division(valor1,valor2));

            }

        }

        //Escribir en el archivo txt

        textWriter.WriteLine(linea[0]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[1]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[2]);
        textWriter.WriteLine();
        textWriter.WriteLine(respuesta);
        textWriter.WriteLine();
        textWriter.WriteLine();

    }
    else if(linea.Count > 3)
    {
        List<string> nuevo = new List<string>();

        for(int i = linea.Count-1;i > linea.Count-4;i--)
        {

            nuevo.Add(linea[i]);

        }

        //Saber si existe alguna fraccion en la operacion
        if(nuevo[2].Contains('/') || nuevo[0].Contains('/'))
        {
            
            //Mandar a llamar si hay alguna fraccion
            respuesta = Fracciones(nuevo[2],nuevo[0],nuevo[1]);

        }
        else
        {
            //Sino hay ninguna fraccion

            valor1 = double.Parse(nuevo[2]);
            valor2 = double.Parse(nuevo[0]);

            //Opciones con el operador
            if(nuevo[1] == "+")
            {

                respuesta += Convert.ToString(Suma(valor1,valor2));

            }
            else if(nuevo[1] == "-")
            {

                respuesta += Convert.ToString(Resta(valor1,valor2));

            }
            else if(nuevo[1] == "*")
            {

                respuesta += Convert.ToString(Multiplicacion(valor1,valor2));

            }
            else if(nuevo[1] == "/")
            {

                respuesta += Convert.ToString(Division(valor1,valor2));

            }

        }

        //Escribir en el archivo txt

        textWriter.WriteLine(nuevo[2]);
        textWriter.WriteLine();
        textWriter.WriteLine(nuevo[1]);
        textWriter.WriteLine();
        textWriter.WriteLine(nuevo[0]);
        textWriter.WriteLine();
        textWriter.WriteLine(respuesta);
        textWriter.WriteLine();
        textWriter.WriteLine();


    }
}

//Cerrar el archivo
textWriter.Close();
