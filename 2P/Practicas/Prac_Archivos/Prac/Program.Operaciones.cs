partial class Program
{
    static double Suma(double a, double b)
    {
        return a + b;
    }

    //Resta numeros enterps
    static double Resta(double a, double b)
    {
        return a - b;
    }

    //Multiplicacion numeros enterps
    static double  Mult(double a, double b)
    {
        return a * b;
    }

    //Division numeros enterps
    static double Div(double a, double b)
    {
        return a / b;
    }

    //Para fracciones
    static string FraccSum(string num1, string den1, string num2, string den2)
    {
        double n1 = Convert.ToInt32(num1);
        double n2 = Convert.ToInt32(num2);
        double d1 = Convert.ToInt32(den1);
        double d2 = Convert.ToInt32(den2);
        double resN;
        double resD;
        string respu = "";

        n1 *= d2;
        n2 *= d1;
        resD = d1 * d2;
        resN = n1 + n2;

        double minimoComunMultiplo = CalcularMCD(resN, resD);
        resN /= minimoComunMultiplo;
        resD /= minimoComunMultiplo;

        if (resD == 1) //Valor entero
        {
            respu += Convert.ToString(resN);
        }
        else
        {
            respu += Convert.ToString(resN);
            respu += "/";
            respu += Convert.ToString(resD);
        }

        return respu;

    }

    static string FraccRes(string num1, string den1, string num2, string den2)
    {
        double n1 = Convert.ToInt32(num1);
        double n2 = Convert.ToInt32(num2);
        double d1 = Convert.ToInt32(den1);
        double d2 = Convert.ToInt32(den2);
        double resN;
        double resD;
        string respu = "";

        n1 *= d2;
        n2 *= d1;
        resD = d1 * d2;
        resN = n1 - n2;

        double minimoComunMultiplo = CalcularMCD(resN, resD);
        resN /= minimoComunMultiplo;
        resD /= minimoComunMultiplo;

        if (resD == 1) //Valor entero
        {
            respu += Convert.ToString(resN);
        }
        else
        {
            respu += Convert.ToString(resN);
            respu += "/";
            respu += Convert.ToString(resD);
        }

        return respu;

    }

    static string FraccMult(string num1, string den1, string num2, string den2)
    {
        double n1 = Convert.ToInt32(num1);
        double n2 = Convert.ToInt32(num2);
        double d1 = Convert.ToInt32(den1);
        double d2 = Convert.ToInt32(den2);
        double resN;
        double resD;
        string respu = "";

        resN = n1 * n2;
        resD = d1 * d2;

        double minimoComunMultiplo = CalcularMCD(resN, resD);
        resN /= minimoComunMultiplo;
        resD /= minimoComunMultiplo;

        if (resD == 1) //Valor entero
        {
            respu += Convert.ToString(resN);
        }
        else
        {
            respu += Convert.ToString(resN);
            respu += "/";
            respu += Convert.ToString(resD);
        }

        return respu;

    }

    //Division
    static string FraccDiv(string num1, string den1, string num2, string den2)
    {
        double n1 = Convert.ToInt32(num1);
        double n2 = Convert.ToInt32(num2);
        double d1 = Convert.ToInt32(den1);
        double d2 = Convert.ToInt32(den2);
        double resN;
        double resD;
        string respu = "";

        resN = n1 * d2;
        resD = d1 * n2;

        double minimoComunMultiplo = CalcularMCD(resN, resD);
        resN /= minimoComunMultiplo;
        resD /= minimoComunMultiplo;

        if (resD == 1) //Valor entero
        {
            respu += Convert.ToString(resN);
        }
        else
        {
            respu += Convert.ToString(resN);
            respu += "/";
            respu += Convert.ToString(resD);
        }

        return respu;

    }
}