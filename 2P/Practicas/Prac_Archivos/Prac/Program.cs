List<List<string>> input;

input = LeerArchivo();

StreamWriter textWriter = File.CreateText("out.txt");

foreach (var linea in input)
{
    double operando1;
    double operando2;

    string res = "res= ";

    //Si es exactamente una operacion
    if(linea.Count == 3)
    {
        if(linea[0].Contains('/') || linea[2].Contains('/'))
        {
            res = CalcularFraccion(linea[0], linea[2], linea[1]); 
        }else
        {
            operando1 = double.Parse(linea[0]);
            operando2 = double.Parse(linea[2]);

            switch (linea[1])
            {
                case "+":
                    res += Convert.ToString(Suma(operando1, operando2));
                    break;
                case "-":
                    res += Convert.ToString(Resta(operando1, operando2));
                    break;
                case "*":
                    res += Convert.ToString(Mult(operando1, operando2));
                    break;
                case "/":
                    res += Convert.ToString(Div(operando1, operando2));
                    break;
                default:
                    break;
            }

        }

        textWriter.WriteLine(linea[0]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[1]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[2]);
        textWriter.WriteLine();
        textWriter.WriteLine(res);
        textWriter.WriteLine();
        textWriter.WriteLine();

    }
    else if(linea.Count > 3)
    {
        List<string> operacion = new();

        for(int i = linea.Count-1; i > linea.Count-4; i--)
        {
            operacion.Add(linea[i]);
        }

        if (operacion[0].Contains('/') || operacion[2].Contains('/'))
        {
            res = CalcularFraccion(operacion[0], operacion[2], operacion[1]);
        }
        else
        {
            operando1 = double.Parse(operacion[0]);
            operando2 = double.Parse(operacion[2]);

            switch (operacion[1])
            {
                case "+":
                    res += Convert.ToString(Suma(operando1, operando2));
                    break;
                case "-":
                    res += Convert.ToString(Resta(operando1, operando2));
                    break;
                case "*":
                    res += Convert.ToString(Mult(operando1, operando2));
                    break;
                case "/":
                    res += Convert.ToString(Div(operando1, operando2));
                    break;
                default:
                    break;
            }

        }

        textWriter.WriteLine(linea[0]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[1]);
        textWriter.WriteLine();
        textWriter.WriteLine(linea[2]);
        textWriter.WriteLine();
        textWriter.WriteLine(res);
        textWriter.WriteLine();
        textWriter.WriteLine();
    }
}

textWriter.Close();