List<List<string>> input;

input = LeerArchivo();

StreamWriter textWriter = File.CreateText("Output.txt");

foreach (var linea in input)
{
    double operando1;
    double operando2;

    string final;

    //Si es exactamente una operacion
    if(linea.Count == 3){
        
    }
}