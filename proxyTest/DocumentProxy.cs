public class DocumentProxy : IDocument
{
    private RealDocument? _document;

    public string Read()
    {
        if(_document == null)
        {
            Console.WriteLine("Создаем документ по запросу");

            _document = new RealDocument();
        }

        return _document.Read()
    }
}
