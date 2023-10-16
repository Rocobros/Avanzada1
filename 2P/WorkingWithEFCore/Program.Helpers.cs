using static System.Console;
partial class Program{
    static void SectionTitle(string message){
        ConsoleColor backgroundColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Green;
        WriteLine("*");
        WriteLine($"*{message}");
        WriteLine("*");
        ForegroundColor = backgroundColor;
    }
    static void Fail(string message)
    {
        ConsoleColor backgroundColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Red;
        WriteLine("*");
        WriteLine($"*{message}");
        WriteLine("*");
        ForegroundColor = backgroundColor;
    }
    static void Info(string message)
    {
        ConsoleColor backgroundColor = ForegroundColor;
        ForegroundColor = ConsoleColor.Cyan;
        WriteLine($"Info > ({message})");
        ForegroundColor = backgroundColor;
    }
}
