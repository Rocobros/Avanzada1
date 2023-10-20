namespace Librerias;

public class Calculadora
{

    //Funcion para leer el txt y prepararlo para las operaciones
    public static List<List<string>> Leer()
    {

        //Lista con el valor real
        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            if(double.TryParse(linea, out _))
            {

                listas.Add(linea); 

            }
            else
            {


            }
             
        }

        //Quitar todos los enters para mejor comodidad
        foreach(var str in listas)
        {
            if(!string.IsNullOrWhiteSpace(str))
            {

                string strSinEnters = str.Replace("\n","");
                nuevalistas.Add(strSinEnters);

            }
            
        }     

        //Creacion de una lista dentro de listas y una lista para meter la informacion
        List<List<string>> respuesta = new List<List<string>>();

        List<string> numeros = new List<string>();

        //Hacer cada operacion una Lista y meterlo en un contenedor de listas
        foreach(var str in nuevalistas)
        {   

            if(str == "res=")
            {

                //numeros.Add(str);

                var expr = new List<string>(numeros);
                respuesta.Add(expr);
                numeros.Clear();

            }
            else
            {

               numeros.Add(str); 

            }

        }      

        List<List<string>> real = new List<List<string>>();

        return respuesta;

    }


    //Funcion para si es una operacion con fraccion o fracciones
    public static string Fracciones(string num1, string num2,string operacion)
    {

        //Inicializar 
        string numerador1 = "";
        string numerador2 = "";
        string denominador1 = "";
        string denominador2 = "";
        bool uno = true;
        bool dos = true;
        string resp= "";


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

    public static int CalcularMCD(int a, int b)
    {
        // Algoritmo de Euclides para calcular el MCD
        /*while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;*/

        int temp = 0;

        for(int i = b;temp != 0 || i > 0;i--)
        {

            if(a % i == 0 && b % i == 0)
            {

                temp = i;
                return temp;

            }

        }

        return 1;
    }

    //Suma numeros enterps
    public static double Suma(double a, double b)
    {

        return a + b;

    }

    //Resta numeros enterps
    public static double Resta(double a, double b)
    {

        return a - b;

    }

    //Multiplicacion numeros enterps
    public static double Multiplicacion(double a, double b)
    {

        return a * b;

    }

    //Division numeros enterps
    public static double Division(double a, double b)
    {

        return a / b;

    }

    //En el caso de que haya una fraccion en la operacion

    //Suma
    public static string FraccSuma(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        int n1 = Convert.ToInt32(numer1);
        int n2 = Convert.ToInt32(numer2);
        int d1 = Convert.ToInt32(denomi1);
        int d2 = Convert.ToInt32(denomi2);
        int r1 = 0;
        int r2 = 0;
        string respu = "";

        //Operacion
        n1 = n1 * d2;

        n2 = n2 * d1;

        r2 = d1 * d2;

        r1 = n1 + n2;

        bool seguir = true;

        //Poner el denominador en minimo comun multiplo
        int minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

        if(r1 < 0 & r2 < 0)
        {

            r1 *= -1;
            r2 *= -1;

        }

        //En el caso de que le resultado denominador es uno 
        if(r2 == 1)
        {

            respu += Convert.ToString(r1);

        }
        else
        {

            respu += Convert.ToString(r1);
            respu += "/";
            respu += Convert.ToString(r2);

        }

        return respu;   

    }

    //Resta
    public static string FraccRes(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        int n1 = Convert.ToInt32(numer1);
        int n2 = Convert.ToInt32(numer2);
        int d1 = Convert.ToInt32(denomi1);
        int d2 = Convert.ToInt32(denomi2);
        int r1 = 0;
        int r2 = 0;
        string respu = "";

        //Operacion
        n1 = n1 * d2;

        n2 = n2 * d1;

        r2 = d1 * d2;

        r1 = n1 - n2;

        //Poner el denominador en minimo comun multiplo
        int minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

        if(r1 < 0 & r2 < 0)
        {

            r1 *= -1;
            r2 *= -1;

        }

        //En el caso de que le resultado denominador es uno 
        if(r2 == 1)
        {

            respu += Convert.ToString(r1);

        }
        else
        {

            respu += Convert.ToString(r1);
            respu += "/";
            respu += Convert.ToString(r2);

        }

        return respu;  

    }

    //Multiplicacion
    public static string FraccMul(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        int n1 = Convert.ToInt32(numer1);
        int n2 = Convert.ToInt32(numer2);
        int d1 = Convert.ToInt32(denomi1);
        int d2 = Convert.ToInt32(denomi2);
        int r1 = 0;
        int r2 = 0;
        string respu = "";

        //Operacion
        r1 = n1 * n2;
        r2 = d1 * d2;

        //Poner el denominador en minimo comun multiplo
        int minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

        if(r1 < 0 & r2 < 0)
        {

            r1 *= -1;
            r2 *= -1;

        }

        //En el caso de que le resultado denominador es uno 
        if(r2 == 1)
        {

            respu += Convert.ToString(r1);

        }
        else
        {

            respu += Convert.ToString(r1);
            respu += "/";
            respu += Convert.ToString(r2);

        }

        return respu;  

    }

    //Division
    public static string FraccDiv(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        int n1 = Convert.ToInt32(numer1);
        int n2 = Convert.ToInt32(numer2);
        int d1 = Convert.ToInt32(denomi1);
        int d2 = Convert.ToInt32(denomi2);
        int r1 = 0;
        int r2 = 0;
        string respu = "";

        //Operacion
        r1 = n1 * d2;

        r2 = d1 * n2;

        //Poner el denominador en minimo comun multiplo
        int minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

        if(r1 < 0 & r2 < 0)
        {

            r1 *= -1;
            r2 *= -1;

        }

        //En el caso de que le resultado denominador es uno 
        if(r2 == 1)
        {

            respu += Convert.ToString(r1);

        }
        else
        {

            respu += Convert.ToString(r1);
            respu += "/";
            respu += Convert.ToString(r2);

        }

        return respu;  

    }

}
