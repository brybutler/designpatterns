namespace GangOf4Patterns.Structural.Flyweight.Characters;
public class Paragraph : ICharacter
{
    private readonly int _location;
    private readonly List<ICharacter> _characters;

    public Paragraph(List<ICharacter> characters, int location)
    {
        _characters = characters;
        _location = location;
    }

    public void Draw(string fontFamily, int fontSize)
    {
        Console.WriteLine($"Drawing in paragraph at location {_location}");
        foreach (var character in _characters)
        {
            character.Draw(fontFamily, fontSize);
        }
    }
}