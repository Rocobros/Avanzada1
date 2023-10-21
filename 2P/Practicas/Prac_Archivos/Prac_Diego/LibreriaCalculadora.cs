using System.Reflection.Metadata;
using System.Runtime.CompilerServices;

partial class Program
{
    static List<List<string>> Leer()
    {

        //Lista con el valor real
        List<string> listas = new();

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test.txt");

        //Añadir las lineas strings a un List de strings quitando la basura
        foreach(var linea in lista)
        {

            if(double.TryParse(linea, out _) || linea == "res=" || linea == "+" || linea == "-" || linea == "/" || linea == "*" || linea.Contains('/'))
            {

                listas.Add(linea);  

            }

        }

        //Creacion de una lista dentro de listas y una lista para meter la informacion
        List<List<string>> respuesta = new();

        List<string> numeros = new();

        //Hacer cada operacion una Lista y meterlo en un contenedor de listas
        foreach(var str in listas)
        {   

            if(str.Contains("res="))
            {
                var expr = new List<string>(numeros);
                respuesta.Add(expr);
                numeros.Clear();
            }
            else
            {
               numeros.Add(str); 
            }

        }      

        return respuesta;

    }


    //Funcion para si es una operacion con fraccion o fracciones
    static string Fracciones(string num1, string num2,string operacion)
    {

        //Inicializar 
        string numerador1 = "";
        string numerador2 = "";
        string denominador1 = "";
        string denominador2 = "";
        bool uno = true;
        bool dos = true;
        string resp= "res= ";


        //Comprobar que es una fraccion
        if(num1.Contains('/'))
        {

            //Repetir por la cantidad de veces en el string y acomodar en nuemeradores y denominadores
            for(int i = 0;i < num1.Length;i++)
            {

                if(num1[i] == '/')
                {

                    //Cambio a dominador
                    uno = false;

                }
                else if(uno == true)
                {

                    numerador1 += num1[i];

                }
                else
                {

                    denominador1 += num1[i];

                }

            }

        }
        else
        {

            numerador1 = num1;
            denominador1 = "1";

        }

        //Comprobar que es una fraccion
        if(num2.Contains('/'))
        {

            for(int i = 0;i < num2.Length;i++)
            {

                if(num2[i] == '/')
                {

                    //Cambio a dominador
                    dos = false;

                }
                else if(dos == true)
                {

                    numerador2 += num2[i];

                }
                else
                {

                    denominador2 += num2[i];

                }

            }


        }
        else
        {

            numerador2 = num2;
            denominador2 = "1";

        }

        if(operacion == "+")//Si es una suma de fracciones
        {

            resp += FraccSuma(numerador1,denominador1,numerador2,denominador2);            

        }
        else if(operacion == "-")//Si es una resta de fracciones
        {

            resp += FraccRes(numerador1,denominador1,numerador2,denominador2);  

        }
        else if(operacion == "*")//Si es una multiplicacion de fracciones
        {

            resp += FraccMul(numerador1,denominador1,numerador2,denominador2);  

        }
        else if(operacion == "/")//Si es una division de fracciones
        {

            resp += FraccDiv(numerador1,denominador1,numerador2,denominador2);  

        }
        
        //Regresa lo que se obtuvo
        return resp;

    }

    static double CalcularMCD(double a, double b)
    {
        double temp = 0;

        // Algoritmo de Euclides para calcular el MCD
        while (b != 0)
        {
            temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
}