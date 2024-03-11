using GangOf4Patterns.Behavioural;
using GangOf4Patterns.Behavioural.Command;
using GangOf4Patterns.Behavioural.Interpreter;
using GangOf4Patterns.Behavioural.Iterator;
using GangOf4Patterns.Behavioural.Mediator;
using GangOf4Patterns.Behavioural.Memento;
using GangOf4Patterns.Behavioural.Observer;
using GangOf4Patterns.Behavioural.State;
using GangOf4Patterns.Creational;
using GangOf4Patterns.Creational.DependencyInjection;
using GangOf4Patterns.Structural;
using GangOf4Patterns.Structural.Bridge;
using GangOf4Patterns.Structural.Composite;
using GangOf4Patterns.Structural.Decorator;
using GangOf4Patterns.Structural.Facade;
using GangOf4Patterns.Structural.Proxy;
using GangOf4Patterns.Behavioural.Strategy;
using GangOf4Patterns.Behavioural.Template;
using GangOf4Patterns.Behavioural.Visitor;
using GangOf4Patterns.Creational.Fluent;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using GangOf4Patterns.Events.Delegate;
using GangOf4Patterns.Events.Event;
using GangOf4Patterns.Structural.Flyweight;
using GangOf4Patterns.Creational.FactoryMethod_BillingSystem;
using GangOf4Patterns.Structural.Bridge2;

using var host = Host.CreateDefaultBuilder(args)
    .UseDefaultServiceProvider((context, options) => {
        options.ValidateScopes = true;
    }).ConfigureServices((context, services) =>
{

    // services.AddTransient<ICreational, RunClonePerson>();

    //services.AddTransient<IPaymentService, PaymentService>();
    //services.AddTransient<ICreditsService, CreditService>();
    //services.AddTransient<ICreational, RunInvoiceService>();
    //services.AddTransient<ICreational, RunInvoiceService>();
    //services.AddTransient<ICreational, RunConvertCity>();
    //services.AddTransient<ICreational, RunFacade>();
    //services.AddTransient<ICreational, RunProxy>();
    //services.AddTransient<ICreational, RunFileSystem>(); 
    //services.AddTransient<ICreational, RunDecorator>();
    //services.TryAddTransient<ICreational, RunSingleton>();
    //services.TryAddTransient<ICreational, RunStrategy>();
    //services.TryAddTransient<ICreational, RunVisitor>();
    //services.TryAddTransient<ICreational, RunInterpreter>();
    //services.TryAddTransient<ICreational, RunIterator>();
    //services.TryAddTransient<ICreational, RunState>();
    //services.TryAddTransient<ICreational, RunObserver>();
    //services.TryAddTransient<ICreational, RunMediator>();
    // services.TryAddTransient<ICreational, RunCommand>();
    //services.TryAddTransient<ICreational, RunMemento>();
    //services.TryAddTransient<ICreational, RunFluent>();
    //services.TryAddTransient<ICreational, RunTemplate>();
    //services.TryAddTransient<ICreational, RunFactoryMethodBillingService>();
    services.TryAddTransient<ICreational, RunMovieLicense>();
    //services.TryAddTransient<ICreational, RunDelegate>();
    // services.TryAddTransient<ICreational, RunEvent>();
    // services.TryAddTransient<ICreational, RunFlyweight>();
    services.AddTransient<DIRunner>();
    services.AddOptions<DIOptions>().Configure<IConfiguration>((options, configuration) =>
    {
        configuration.GetSection(DIOptions.SectionName).Bind(options);
    });
}).Build();

var dIRunner = host.Services.GetRequiredService<DIRunner>();

dIRunner.Run();

