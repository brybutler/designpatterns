namespace GangOf4Patterns.Creational.Fluent;
public class Burger
{
    public int NumPatties { get; set; }
    public bool Cheese { get; set; }
    public bool Bacon { get; set; }
    public bool Pickles { get; set; }
    public bool Lettuce { get; set; }
    public bool Tomato { get; set; }
    public Burger(int numPatties = 1)
    {
        NumPatties = numPatties;
    }

    public void PrintOrder()
    {
        Console.WriteLine("New burger with");

        if (NumPatties != 1) Console.WriteLine($"\t {NumPatties} patties");

        if (Cheese) Console.WriteLine("\t cheese");

        if (Lettuce) Console.WriteLine("\t lettuce");

        if (Tomato) Console.WriteLine("\t tomato");

        if (Pickles) Console.WriteLine("\t pickles");

        if (Bacon) Console.WriteLine("\t bacon");

        Console.WriteLine("=========");
    }
}