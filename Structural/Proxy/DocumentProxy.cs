namespace GangOf4Patterns.Structural.Proxy;
public class DocumentProxy : IDocument
{
    private Document? _document;
    private string _fileName;

    public DocumentProxy(string fileName)
    {
        _fileName = fileName;
    }

    public void DisplayDocument()
    {
        if (_document == null)
            _document = new Document(_fileName);

        _document.DisplayDocument();
    }
}

