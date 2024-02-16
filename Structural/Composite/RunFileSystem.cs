using GangOf4Patterns.Creational;
namespace GangOf4Patterns.Structural.Composite;
public class RunFileSystem : ICreational
{
    public void Execute(string title)
    {
        Console.Title = title;
        var root = new CacheDirectory("root", 0);

        var topLevelFile = new CacheFile("file", 1000);

        var top1 = new CacheDirectory("top1", 0);
        var top2 = new CacheDirectory("top2", 0);

        root.Add(topLevelFile);
        root.Add(top1);
        root.Add(top2);

        var subLevelFile = new CacheFile("subfile", 50);
        var subLevelFile1 = new CacheFile("subfile1", 40);

        top1.Add(subLevelFile);
        top2.Add(subLevelFile1);

        Console.WriteLine($"top1 directory size: {top1.GetSize()}");
        Console.WriteLine($"top2 directory size: {top2.GetSize()}");
        Console.WriteLine($"root directory size: {root.GetSize()}");

        Console.ReadKey();
    }
}