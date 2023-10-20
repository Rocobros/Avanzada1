partial class Program
{

    //Suma numeros enterps
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
    static double Multiplicacion(double a, double b)
    {

        return a * b;

    }

    //Division numeros enterps
    static double Division(double a, double b)
    {

        return a / b;

    }
    

    //En el caso de que haya una fraccion en la operacion

    //Suma
    static string FraccSuma(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        double n1 = Convert.ToInt32(numer1);
        double n2 = Convert.ToInt32(numer2);
        double d1 = Convert.ToInt32(denomi1);
        double d2 = Convert.ToInt32(denomi2);
        double r1;
        double r2;
        string respu = "";

        //Operacion
        n1 *= d2;

        n2 *= d1;

        r2 = d1 * d2;

        r1 = n1 + n2;

        //Poner el denominador en minimo comun multiplo
        double minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

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
    static string FraccRes(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        double n1 = Convert.ToInt32(numer1);
        double n2 = Convert.ToInt32(numer2);
        double d1 = Convert.ToInt32(denomi1);
        double d2 = Convert.ToInt32(denomi2);
        double r1 = 0;
        double r2 = 0;
        string respu = "";

        //Operacion
        n1 = n1 * d2;

        n2 = n2 * d1;

        r2 = d1 * d2;

        r1 = n1 - n2;

        //Poner el denominador en minimo comun multiplo
        double minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

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
    static string FraccMul(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        double n1 = Convert.ToInt64(numer1);
        double n2 = Convert.ToInt64(numer2);
        double d1 = Convert.ToInt64(denomi1);
        double d2 = Convert.ToInt64(denomi2);
        double r1 = 0;
        double r2 = 0;
        string respu = "";

        //Operacion
        r1 = n1 * n2;
        r2 = d1 * d2;

        //Poner el denominador en minimo comun multiplo
        double minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

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
    static string FraccDiv(string numer1, string denomi1, string numer2, string denomi2)
    {

        //Inicializar variables
        double n1 = Convert.ToInt32(numer1);
        double n2 = Convert.ToInt32(numer2);
        double d1 = Convert.ToInt32(denomi1);
        double d2 = Convert.ToInt32(denomi2);
        double r1 = 0;
        double r2 = 0;
        string respu = "";

        //Operacion
        r1 = n1 * d2;

        r2 = d1 * n2;

        //Poner el denominador en minimo comun multiplo
        double minimoComunMultiplo = CalcularMCD(r1,r2);

        r1 /= minimoComunMultiplo;
        r2 /= minimoComunMultiplo;

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