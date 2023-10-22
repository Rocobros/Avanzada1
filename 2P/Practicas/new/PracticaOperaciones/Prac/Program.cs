List<List<string>> input;

input = LeerArchivo();

StreamWriter textWriter = File.CreateText("out.txt");

foreach (var linea in input)
{
    double operando1;
    double operando2;

    string res = "res= ";

    //Si es exactamente una nuevo
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
        List<string> nuevo = new();

        for(int i = linea.Count-1; i > linea.Count-4; i--)
        {
            nuevo.Add(linea[i]);
        }

        if (nuevo[0].Contains('/') || nuevo[2].Contains('/'))
        {
            res = CalcularFraccion(nuevo[0], nuevo[2], nuevo[1]);
        }
        else
        {
            operando1 = double.Parse(nuevo[0]);
            operando2 = double.Parse(nuevo[2]);

            switch (nuevo[1])
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

        textWriter.WriteLine(nuevo[0]);
        textWriter.WriteLine();
        textWriter.WriteLine(nuevo[1]);
        textWriter.WriteLine();
        textWriter.WriteLine(nuevo[2]);
        textWriter.WriteLine();
        textWriter.WriteLine(res);
        textWriter.WriteLine();
        textWriter.WriteLine();
    }
}

textWriter.Close();