namespace GangOf4Patterns.Structural.Proxy;
public class Document : IDocument
{
    public string? Title { get; private set; }
    public string? Content { get; private set; }
    public int AutherId { get; private set; }
    public DateTimeOffset LastAccessed { get; private set; }
    private string _fileName;

    public Document(string fileName)
    {
        _fileName = fileName;
        LoadDocument(fileName);
    }

    private void LoadDocument(string fileName)
    {
        Console.WriteLine("Executing expensive action");
        Thread.Sleep(1000);

        Title = "Big document";
        Content = "Lots...";
        AutherId = 1;
        LastAccessed = DateTimeOffset.UtcNow;
    }

    public void DisplayDocument()
    {
        Console.WriteLine($"Title: {Title}, Content: {Content}");
    }

}