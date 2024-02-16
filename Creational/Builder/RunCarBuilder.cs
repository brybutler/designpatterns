using GangOf4Patterns.Creational.Builder.Model;
using GangOf4Patterns.Creational.Builder.Services;

namespace GangOf4Patterns.Creational
{
    public class RunCarBuilder
    {
        public void Execute()
        {
            Console.Title = "Builder";

            var garage = new Garage();

            var miniBuilder = new MiniBuilder();
            garage.Construct(miniBuilder);
            Console.WriteLine(miniBuilder.Car.ToString());

            var bmwBuilder = new BmwBuilder();
            garage.Construct(bmwBuilder);
            Console.WriteLine(bmwBuilder.Car.ToString());
            Console.ReadKey();
        }
    }
}
