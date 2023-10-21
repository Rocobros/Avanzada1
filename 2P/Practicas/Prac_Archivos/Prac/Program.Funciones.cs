partial class Program
{
    static List<List<string>> LeerArchivo()
    {
        List<string> archivo = new();

        string[] aux;

        aux = File.ReadAllLines("in.txt");

        foreach (var linea in aux)
        {
            if (double.TryParse(linea, out _) || linea == "res=" || linea == "+" || linea == "-" || linea == "/" || linea == "*" || linea.Contains('/'))
            archivo.Add(linea);
        }

        List<List<string>> res = new();
        List<string> operacion = new();

        foreach (var linea in archivo)
        {
            if(linea.Contains("res="))
            {
                var op = new List<string>(operacion);
                res.Add(op);
                operacion.Clear();
            }
            else
            {
                operacion.Add(linea);
            }     
        }
        return res;
    }

    static string CalcularFraccion(string num, string den, string op)
    {
        string n1 = "";
        string d1 = "";
        string n2 = ""; 
        string d2 = "";
        bool numer = true;
        bool denom = true;
        string res = "res= ";

        for(int i = 0; i < num.Length-1; i++)
        {
            if(num[i] == '/')
                numer = false;
            else if(numer == true)
                n1+=num[i];
            else
                d1+=num[i];
        }

        for (int i = 0; i < den.Length - 1; i++)
        {
            if (den[i] == '/')
                denom = false;
            else if (denom == true)
                n2+=den[i];
            else
                d2+=den[i];
        }

        switch (op)
        {
            case "+":
                res += FraccSum(n1,d1,n2,d2);  
                break;
            case "-":
                res += FraccRes(n1, d1, n2, d2);
                break;
            case "*":
                res += FraccMult(n1, d1, n2, d2);
                break;
            case "/":
                res += FraccDiv(n1, d1, n2, d2);
                break;
            default:
                break;
        }

        return res;
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