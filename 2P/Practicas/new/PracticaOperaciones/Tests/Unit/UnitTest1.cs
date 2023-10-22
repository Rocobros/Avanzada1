namespace Tests;

using System;
using Lib;
using Xunit;

public class UnitTest1
{
    [Fact]
    public void Suma()
    {
        double o1 = 10.5;
        double o2 = 5;
        double expected = 15.5;
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(o1);
        textWriter.WriteLine();
        textWriter.WriteLine("+");
        textWriter.WriteLine();
        textWriter.WriteLine(o2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {

                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);

            }
        }

        double valor1 = double.Parse(archivoSinEnters[0]);
        string operacion = archivoSinEnters[1];
        double valor2 = double.Parse(archivoSinEnters[2]);

        respuesta = Calculadora.Suma(valor1, valor2);

        StreamWriter textWriter2 = File.CreateText("ResTestSuma.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("+");
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);
    }
    [Fact]
    public void Resta()
    {
        double o1 = 10.5;
        double o2 = 5;
        double expected = 5.5;
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(o1);
        textWriter.WriteLine();
        textWriter.WriteLine("-");
        textWriter.WriteLine();
        textWriter.WriteLine(o2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {

                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);

            }
        }

        double valor1 = double.Parse(archivoSinEnters[0]);
        string operacion = archivoSinEnters[1];
        double valor2 = double.Parse(archivoSinEnters[2]);

        respuesta = Calculadora.Resta(valor1, valor2);

        StreamWriter textWriter2 = File.CreateText("ResTestResta.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("-");
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);
    }
    [Fact]
    public void Mult()
    {
        double o1 = 100;
        double o2 = 5;
        double expected = 500;
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(o1);
        textWriter.WriteLine();
        textWriter.WriteLine("*");
        textWriter.WriteLine();
        textWriter.WriteLine(o2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {

                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);

            }
        }

        double valor1 = double.Parse(archivoSinEnters[0]);
        string operacion = archivoSinEnters[1];
        double valor2 = double.Parse(archivoSinEnters[2]);

        respuesta = Calculadora.Multiplicacion(valor1, valor2);

        StreamWriter textWriter2 = File.CreateText("ResTestMult.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("*");
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);
    }
    [Fact]
    public void Div()
    {
        double o1 = 100;
        double o2 = 5;
        double expected = 20;
        double respuesta = 0;

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(o1);
        textWriter.WriteLine();
        textWriter.WriteLine("/");
        textWriter.WriteLine();
        textWriter.WriteLine(o2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {

                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);

            }
        }

        double valor1 = double.Parse(archivoSinEnters[0]);
        string operacion = archivoSinEnters[1];
        double valor2 = double.Parse(archivoSinEnters[2]);

        respuesta = Calculadora.Division(valor1, valor2);

        StreamWriter textWriter2 = File.CreateText("ResTestDiv.txt");
        textWriter2.WriteLine(valor1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("/");
        textWriter2.WriteLine();
        textWriter2.WriteLine(valor2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);
    }
    [Fact]
    public void SumaFrac()
    {
        string n1 = "1/2";
        string n2 = "1/4";
        string expected = "3/4";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine("+");
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, "+");

        StreamWriter textWriter2 = File.CreateText("ResTestFracSuma.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("+");
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void RestaFrac()
    {
        string n1 = "2/2";
        string n2 = "1/2";
        string expected = "1/2";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine("-");
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, "-");

        StreamWriter textWriter2 = File.CreateText("ResTestFracResta.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("-");
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void MultFrac()
    {
        string n1 = "1/2";
        string n2 = "1/2";
        string expected = "1/4";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine("*");
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, "*");

        StreamWriter textWriter2 = File.CreateText("ResTestFracMult.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("*");
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void DivFrac()
    {
        string n1 = "2/4";
        string n2 = "3/2";
        string expected = "1/3";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine("/");
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, "/");

        StreamWriter textWriter2 = File.CreateText("ResTestFracResta.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine("/");
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res= " + respuesta);
        textWriter2.Close();

        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void SumaCombinada()
    {
        string n1 = "1/2";
        string n2 = "3";
        string expected = "7/2";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }
        
        respuesta = Calculadora.Fracciones(n1,n2,operacion);

        
        StreamWriter textWriter2 = File.CreateText("ResCombinacionSuma.txt");
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
    public void RestaCombinada()
    {

        string n1 = "1/2";
        string n2 = "-1/4";
        string expected = "3/4";

        string operacion = "-";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, operacion);


        StreamWriter textWriter2 = File.CreateText("ResCombinacionResta.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        
        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void MultCombinada()
    {
        string n1 = "1/2";
        string n2 = "-1/4";
        string expected = "-1/8";

        string operacion = "*";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, operacion);


        StreamWriter textWriter2 = File.CreateText("ResCombinacionResta.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        
        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void DivCombinada()
    {
        string n1 = "-1/2";
        string n2 = "-3";
        string expected = "1/6";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        respuesta = Calculadora.Fracciones(n1, n2, operacion);


        StreamWriter textWriter2 = File.CreateText("ResCombinacionResta.txt");
        textWriter2.WriteLine(n1);
        textWriter2.WriteLine();
        textWriter2.WriteLine(operacion);
        textWriter2.WriteLine();
        textWriter2.WriteLine(n2);
        textWriter2.WriteLine();
        textWriter2.WriteLine("res=" + respuesta);
        textWriter2.Close();

        
        Assert.Equal(expected, respuesta);

    }
    [Fact]
    public void FormatException()
    {
        Exception excepcion = null;
        bool excepcionValida = false; //Cuando la excepcion no es lanzada pero la operacion no es valida

        double v1 = double.PositiveInfinity;
        double v2 = double.PositiveInfinity;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Calculadora.Fracciones(n1,n2,operacion);
            double? s = double.Parse(respuesta);
            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        
    
        if (excepcion != null) 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is FormatException);

        }
        else 
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResFormatException.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }

    }
    [Fact]
    public void NaNException()
    {
        Exception excepcion = null;
        bool excepcionValida = false; 

        double v1 = 10;
        double v2 = double.NaN;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Calculadora.Fracciones(n1, n2, operacion);
            double? s = double.Parse(respuesta);
            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
            
        }

        if (excepcion != null)
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is FormatException);

        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResNanException.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }
    }
    [Fact]
    public void OverflowException()
    {
        Exception excepcion = null;
        bool excepcionValida = false; 

        double v1 = double.PositiveInfinity;
        double v2 = double.PositiveInfinity;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);
            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }
        
        if (excepcion != null) 
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is OverflowException);

        }
        else 
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResOverflowTest.txt");
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
    public void UnderflowException()
    {
        Exception excepcion = null;
        bool excepcionValida = false;

        double v1 = double.MinValue;
        double v2 = double.MinValue;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);
            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);
        }
        catch (Exception e)
        {
            excepcion = e;
        }

        if (excepcion != null)
        {
            Console.WriteLine($"Excepcion de tipo {excepcion.GetType().FullName}");
            Assert.True(excepcion is OverflowException);

        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResOverflowTest.txt");
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
    public void IsInfinityException()
    {
        Exception excepcion = null;
        bool excepcionValida = false;

        double v1 = double.PositiveInfinity;
        double v2 = 0;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);

        }
        catch (Exception e)
        {
            excepcion = e;
        }

        if (excepcion != null)
        {

        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResIsInfinityTest.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }

    }
    [Fact]
    public void NullException()
    {
        Exception excepcion = null;
        bool excepcionValida = false;

        double v1 = double.PositiveInfinity;
        double? v2 = null;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "1/6";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);

        }
        catch (Exception e)
        {
            excepcion = e;
        }

        if (excepcion != null)
        {
            Assert.True(excepcion is FormatException);
        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResIsInfinityTest.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }
    }
    [Fact]
    public void DivideByZeroException()
    {
        Exception excepcion = null;
        bool excepcionValida = false;

        double v1 = 10;
        double? v2 = 0;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "/";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Division(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);

            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);

        }
        catch (Exception e)
        {
            excepcion = e;
        }

        if (excepcion != null)
        {
            Assert.True(excepcion is DivideByZeroException);
        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResDivideByZeroTest.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }
    }
    [Fact]
    public void InvalidException()
    {
        Exception excepcion = null;
        bool excepcionValida = false;

        double? v1 = double.NaN;
        double? v2 = null;

        string n1 = Convert.ToString(v1);
        string n2 = Convert.ToString(v2);
        string expected = "0";

        string operacion = "+";
        string respuesta = "";

        StreamWriter textWriter = File.CreateText("Test.txt");
        textWriter.WriteLine(n1);
        textWriter.WriteLine();
        textWriter.WriteLine(operacion);
        textWriter.WriteLine();
        textWriter.WriteLine(n2);
        textWriter.WriteLine();
        textWriter.WriteLine("res=");
        textWriter.Close();

        List<string> archivo = new();
        List<string> archivoSinEnters = new();

        string[] leer;
        leer = File.ReadAllLines("Test.txt");

        foreach (var linea in leer)
        {
            archivo.Add(linea);
        }

        foreach (var linea in archivo)
        {
            if (!string.IsNullOrWhiteSpace(linea))
            {
                string lineaSinEnters = linea.Replace("\n", "");
                archivoSinEnters.Add(lineaSinEnters);
            }
        }

        try
        {
            respuesta = Convert.ToString(Calculadora.Suma(Convert.ToDouble(n1), Convert.ToDouble(n2)));
            double? s = double.Parse(respuesta);
            excepcionValida = double.IsInfinity(s.Value) | double.IsNaN(s.Value);

        }
        catch (Exception e)
        {
            excepcion = e;
        }

        if (excepcion != null)
        {
            Assert.True(
                        excepcion is FormatException
                        );
        }
        else
        {
            if (excepcionValida)
            {
                Console.WriteLine($"No se lanzo ninguna excepcion, sin embargo la operacion no es valida");
                Assert.True(excepcionValida);
            }
            else
            {
                StreamWriter textWriter2 = File.CreateText("ResDivideByZeroTest.txt");
                textWriter2.WriteLine(n1);
                textWriter2.WriteLine();
                textWriter2.WriteLine(operacion);
                textWriter2.WriteLine();
                textWriter2.WriteLine(n2);
                textWriter2.WriteLine();
                textWriter2.WriteLine("res=" + respuesta);
                textWriter2.Close();

                Assert.Equal(expected, respuesta);
            }
        }
    }
}