using GangOf4Patterns.Creational.DependencyInjection;
using Microsoft.Extensions.Options;

namespace GangOf4Patterns.Creational;

public class DIRunner
{
    private readonly IOptions<DIOptions> _diOptions;
    private string _title;
    public ICreational _creational { get; set; }
    public DIRunner(IOptions<DIOptions> diOptions, ICreational creational)
    {
        this._creational = creational;
        this._diOptions = diOptions;
    }

    public void Run()
    {
        _title = _diOptions.Value.Title;
        _creational.Execute(_title);
    }

}

