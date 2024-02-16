using GangOf4Patterns.Behavioural.Interpreter.Context;
using GangOf4Patterns.Behavioural.Interpreter.Expression;
using GangOf4Patterns.Creational;

namespace GangOf4Patterns.Behavioural.Interpreter;

public class RunInterpreter : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;

        var expressions = new List<RomanExpression>
        {
            new RomanHundredExpression(),
            new RomanTenExpression(),
            new RomanOneExpression()
        };

        var context = new RomanContext(6);
        foreach (var expression in expressions)
        {
            expression.Interpret(context);
        }
        Console.WriteLine(context.Output);

        context = new RomanContext(273);
        foreach (var expression in expressions)
        {
            expression.Interpret(context);
        }
        Console.WriteLine(context.Output);

        context = new RomanContext(752);
        foreach (var expression in expressions)
        {
            expression.Interpret(context);
        }
        Console.WriteLine(context.Output);

        Console.ReadKey();
    }
}