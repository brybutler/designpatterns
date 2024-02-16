namespace GangOf4Patterns.Behavioural.Interpreter.Context;

public class RomanContext
{
    public int Input { get; set; }
    public string Output { get; set; } = String.Empty;
    public RomanContext(int input)
    {
        Input = input;
    }
}