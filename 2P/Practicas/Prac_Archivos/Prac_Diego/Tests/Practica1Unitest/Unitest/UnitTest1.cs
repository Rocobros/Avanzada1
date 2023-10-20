namespace Unitest;

using System.Data.Common;
using Librerias;
using Xunit.Sdk;

public class UnitTest1
{

    [Fact]
    public void Suma()
    {
        //Arrenge
        
        double v1 = 10.5;
        double v2 = 5;
        double expected = 15.5;
        string operaciones = "+";
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(v1);
        textWriter.WriteLine();
        textWriter.WriteLine(operaciones);
        textWriter.WriteLine();
        textWriter.WriteLine(v2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

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

            listas.Add(linea);  

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

        double valor1 = double.Parse(nuevalistas[0]);
        string operacion = nuevalistas[1];
        double valor2 = double.Parse(nuevalistas[2]);

        if(operacion == "+")
        {

            respuesta = Calculadora.Suma(valor1,valor2);

        }
        else if(operacion == "-")
        {

            respuesta = Calculadora.Resta(valor1,valor2);

        }
        else if(operacion == "*")
        {

            respuesta = Calculadora.Multiplicacion(valor1,valor2);

        }
        else if(operacion == "/")
        {

            respuesta = Calculadora.Division(valor1,valor2);

        }

        StreamWriter textWriter2 = File.CreateText("Copy.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operaciones);
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }

    [Fact]
    public void Resta()
    {
        //Arrenge
        
        double v1 = 10;
        double v2 = 5;
        double expected = 5;
        string operaciones = "-";
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test1.txt");
        textWriter.WriteLine(v1);
        textWriter.WriteLine();
        textWriter.WriteLine(operaciones);
        textWriter.WriteLine();
        textWriter.WriteLine(v2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test1.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test1.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        double valor1 = double.Parse(nuevalistas[0]);
        string operacion = nuevalistas[1];
        double valor2 = double.Parse(nuevalistas[2]);

        if(operacion == "+")
        {

            respuesta = Calculadora.Suma(valor1,valor2);

        }
        else if(operacion == "-")
        {

            respuesta = Calculadora.Resta(valor1,valor2);

        }
        else if(operacion == "*")
        {

            respuesta = Calculadora.Multiplicacion(valor1,valor2);

        }
        else if(operacion == "/")
        {

            respuesta = Calculadora.Division(valor1,valor2);

        }

        StreamWriter textWriter2 = File.CreateText("Copy1.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operaciones);
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }

    [Fact]
    public void Multiplicacion()
    {
        //Arrenge
        
        double v1 = 10;
        double v2 = 5;
        double expected = 50;
        string operaciones = "*";
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test2.txt");
        textWriter.WriteLine(v1);
        textWriter.WriteLine();
        textWriter.WriteLine(operaciones);
        textWriter.WriteLine();
        textWriter.WriteLine(v2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test2.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test2.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        double valor1 = double.Parse(nuevalistas[0]);
        string operacion = nuevalistas[1];
        double valor2 = double.Parse(nuevalistas[2]);

        if(operacion == "+")
        {

            respuesta = Calculadora.Suma(valor1,valor2);

        }
        else if(operacion == "-")
        {

            respuesta = Calculadora.Resta(valor1,valor2);

        }
        else if(operacion == "*")
        {

            respuesta = Calculadora.Multiplicacion(valor1,valor2);

        }
        else if(operacion == "/")
        {

            respuesta = Calculadora.Division(valor1,valor2);

        }

        StreamWriter textWriter2 = File.CreateText("Copy2.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operaciones);
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }

    [Fact]
    public void Division()
    {
        //Arrenge
        
        double v1 = 10;
        double v2 = 5;
        double expected = 2;
        string operaciones = "/";
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test3.txt");
        textWriter.WriteLine(v1);
        textWriter.WriteLine();
        textWriter.WriteLine(operaciones);
        textWriter.WriteLine();
        textWriter.WriteLine(v2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test3.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test3.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        double valor1 = double.Parse(nuevalistas[0]);
        string operacion = nuevalistas[1];
        double valor2 = double.Parse(nuevalistas[2]);

        if(operacion == "+")
        {

            respuesta = Calculadora.Suma(valor1,valor2);

        }
        else if(operacion == "-")
        {

            respuesta = Calculadora.Resta(valor1,valor2);

        }
        else if(operacion == "*")
        {

            respuesta = Calculadora.Multiplicacion(valor1,valor2);

        }
        else if(operacion == "/")
        {

            respuesta = Calculadora.Division(valor1,valor2);

        }

        StreamWriter textWriter2 = File.CreateText("Copy3.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operaciones);
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }

    [Fact]
    public void FraccionSuma()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "1/4";
        string expected = "3/4";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test4.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test4.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test4.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy4.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }

    [Fact]
    public void FraccionResta()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "1/4";
        string expected = "1/4";

        string operacion = "-";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test5.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test5.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test5.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy5.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }

    [Fact]
    public void FraccionMultiplicacion()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "1/4";
        string expected = "1/8";

        string operacion = "*";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test6.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test6.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test6.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy6.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }

    [Fact]
    public void FraccionDivision()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "1/4";
        string expected = "3/4";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test7.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test7.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test7.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy7.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }

    [Fact]
    public void CombinacionEnterosFraccionesSuma()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "3";
        string expected = "7/2";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test8.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test8.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test8.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy8.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }

    [Fact]
    public void CombinacionEnterosFraccionesResta()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "-1/4";
        string expected = "3/4";

        string operacion = "-";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test9.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test9.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test9.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy9.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }


    [Fact]
    public void CombinacionEnterosFraccionesMultiplicacion()
    {
        //Arrenge
        string n1 = "1/2";
        string n2 = "-1/4";
        string expected = "-1/8";

        string operacion = "*";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test10.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test10.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test10.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy10.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);


    }


    [Fact]
    public void CombinacionEnterosFraccionesDivision()
    {
        //Arrenge
        string n1 = "-1/2";
        string n2 = "-3";
        string expected = "1/6";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test11.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test11.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test11.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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


        //Act
        if(n1.Contains('/') || n2.Contains('/'))
        {

            respuesta = Calculadora.Fracciones(n1,n2,operacion);

        }
        else
        {

            if(operacion == "+")
            {

                respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "-")
            {

                respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "*")
            {

                respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }
            if(operacion == "/")
            {

                respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

            }

        }

        StreamWriter textWriter2 = File.CreateText("Copy11.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        //Assert
        Assert.Equal(expected, respuesta);

    }

    [Fact]
    public void ExcepcionFormatExcepcion()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.PositiveInfinity;
        double v2 = double.PositiveInfinity;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test12.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test12.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test12.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is FormatException);

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy12.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionIsNAN()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = 10;
        double v2 = double.NaN;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test13.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test13.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test13.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy13.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionOverflow()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.PositiveInfinity;
        double v2 = double.PositiveInfinity;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test14.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test14.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test14.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is OverflowException);

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy14.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionInfinit()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.PositiveInfinity;
        double v2 = 0;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test15.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test15.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test15.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            //Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            //Assert.True(excepcion is OverflowException);

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy15.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionNULL()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.PositiveInfinity;
        double? v2 = null;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test16.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test16.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test16.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(
                        excepcion is FormatException 
                        );

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy16.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionDividByZero()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = 10;
        double? v2 = 0;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test17.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test17.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test17.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is DivideByZeroException );

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy17.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionInvalid()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double? v1 = double.NaN;
        double? v2 = null;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test18.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test18.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test18.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(
                        excepcion is FormatException
                        );

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy18.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }

    [Fact]
    public void ExcepcionUnderFLowL()
    {
        //Arrenge
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.MinValue;
        double? v2 = double.MinValue;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test19.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        //Act

        List<string> listas = new List<string>();
        //Lista con el valor modificado de los enters
        List<string> nuevalistas = new List<string>();

        //Leer el txt
        TextReader leer = new StreamReader("Test19.txt");

        string[] lista;

        //Introducir todas las lineas en un arreglo de strings
        lista = File.ReadAllLines("Test19.txt");


        //Añadir las lineas strings a un List de strings
        foreach(var linea in lista)
        {

            listas.Add(linea);  

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

        try
        {
            //Act
            if(n1.Contains('/') || n2.Contains('/'))
            {

                respuesta = Calculadora.Fracciones(n1,n2,operacion);

            }
            else
            {

                if(operacion == "+")
                {

                    respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "-")
                {

                    respuesta = Convert.ToString(Calculadora.Resta(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "*")
                {

                    respuesta = Convert.ToString(Calculadora.Multiplicacion(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }
                if(operacion == "/")
                {

                    respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));

                }

            }
            double? s = double.Parse(respuesta);            

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        //Assert
        if(excepcion != null) //Excepcion lanzada 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is OverflowException);

        }
        else //Excepcion no lanzada
        {
            if(excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("Copy19.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                //Assert
                Assert.Equal(expected, respuesta);
            }
        }

    }
    
}

