using static System.Console;

Write("Type the name of the file to be created: ");
var name = ReadLine();

name = ClearName(name);

var path = Path.Combine(Environment.CurrentDirectory, $"{name}.txt");

CreateArchive(path);

WriteLine("Type enter to finish...");
ReadLine();

static string ClearName(string name)
{
        foreach (var @char in Path.GetInvalidFileNameChars()) //used @ to force .Net to accept a reserved name 'char'
    {
        name = name.Replace(@char,'-'); //this line will replace any inputed invalid char with '-'
    }
    return name;
}

static void CreateArchive(string path)
{
    try
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("Está é a linha 1 do arquivo");
        sw.WriteLine("Está é a linha 2 do arquivo");
        sw.WriteLine("Está é a linha 3 do arquivo");
    }
    catch (System.Exception)
    {
        WriteLine("O nome do arquivo é inválido!");
    }
}