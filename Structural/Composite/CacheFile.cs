namespace GangOf4Patterns.Structural.Composite;
public class CacheFile : FileSystemItem
{
    private long _size;

    public CacheFile(string name, long size) : base(name)
    {
        _size = size;
    }

    public override long GetSize()
    {
        return _size;
    }
}