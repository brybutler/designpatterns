namespace GangOf4Patterns.Structural.Composite;
public class CacheDirectory : FileSystemItem
{
    private List<FileSystemItem> _fileSystemItems = new List<FileSystemItem>();

    private long _size;

    public CacheDirectory(string name, long size) : base(name) => _size = size;

    public void Add(FileSystemItem itemToAdd) => _fileSystemItems.Add(itemToAdd);

    public void Remove(FileSystemItem itemToAdd) => _fileSystemItems.Remove(itemToAdd);

    public override long GetSize()
    {
        var treeSize = _size;
        foreach (var fileSystemItem in _fileSystemItems)
        {
            treeSize += fileSystemItem.GetSize();
        }

        return treeSize;
    }

}