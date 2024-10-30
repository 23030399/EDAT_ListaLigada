using ListaLigada.Logica;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lista ligada simple\n");
        var SingleList = new SingleList<string>();
        SingleList.Add("Juan");
        SingleList.Add("Jan");
        SingleList.Add("Jun");
        Console.WriteLine(SingleList);
    }
}