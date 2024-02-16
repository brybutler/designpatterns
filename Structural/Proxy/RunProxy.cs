using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Structural.Proxy
{
    public class RunProxy: ICreational
    {
        public void Execute(string title)
        {
            Console.Title = title;

            /* without Proxy*/
            Console.WriteLine("Constructing document");
            var myDocument = new Document("MyDocument.pdf");

            Console.WriteLine("Document constructed");

            myDocument.DisplayDocument();

            Console.WriteLine();
            
            // with Proxy
            Console.WriteLine("Constructing document proxy");
            var myDocumentProxy = new DocumentProxy("MyDocument.pdf");
            Console.WriteLine("Document proxy constructed");
            myDocumentProxy.DisplayDocument();

            Console.ReadKey();
        }
    }
}
