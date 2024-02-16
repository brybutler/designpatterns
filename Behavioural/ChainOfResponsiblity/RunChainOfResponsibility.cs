using System.ComponentModel.DataAnnotations;
using GangOf4Patterns.Behavioural.ChainOfResponsiblity.Handlers;
using GangOf4Patterns.Behavioural.ChainOfResponsiblity.Models;

namespace GangOf4Patterns.Behavioural.ChainOfResponsiblity;
public class RunChainOfResponsibility
{
    public void Execute()
    {
        Console.Title = "Chain of Responsibility";

        var validDocument = new Document("Test", DateTime.UtcNow, true, true);
        var invalidDocument = new Document("Test", DateTime.UtcNow, false, true);

        var documentHandlerChain = new DocumentTitleHandler();
        documentHandlerChain.SetSuccessor(new DocumentValidLegalHandler())
            .SetSuccessor(new DocumentValidManagementHandler());

        try
        {
            documentHandlerChain.Handle(validDocument);
            Console.WriteLine("Valid document is valid");

            documentHandlerChain.Handle(invalidDocument);
            Console.WriteLine("Invalid document is valid");
        }
        catch (ValidationException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }

    
}
