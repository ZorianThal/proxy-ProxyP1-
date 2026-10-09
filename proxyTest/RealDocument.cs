public class RealDocument : IDocument
{
    public string Read()
    {
        Console.WriteLine("Читаем настоящий документ");

        return "Содержимое документа";
    }
}