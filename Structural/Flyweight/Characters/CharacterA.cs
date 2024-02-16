namespace GangOf4Patterns.Structural.Flyweight.Characters;
public class CharacterA : ICharacter
{
    private const char ActualCharacter = 'a';
    private string _fontFamily = string.Empty;
    private int _fontSize;

    public void Draw(string fontFamily, int fontSize)
    {
        _fontFamily = fontFamily;
        _fontSize = fontSize;
        Console.WriteLine($"Drawing {ActualCharacter}, {_fontFamily}, {_fontSize}");
    }
}