using GangOf4Patterns.Creational;
using GangOf4Patterns.Creational.FactoryMethod.Factories;

namespace GangOf4Patterns.Creational
{
    public class RunFactoryMethod
    {
        public void Execute()
        {
            Console.Title = "Factory Method";

            var codeDiscountFactory = new CodeDiscountFactory(Guid.NewGuid());
            var codeDiscountService = codeDiscountFactory.CreateDiscountService();
            Console.WriteLine($"Percentage {codeDiscountService.DiscountPercentage} from {codeDiscountService}");

            var countryDiscountFactory = new CountryDiscountFactory("IE");

            var countryDiscountService = countryDiscountFactory.CreateDiscountService();
            Console.WriteLine($"Percentage {countryDiscountService.DiscountPercentage} from {countryDiscountService}");


            Console.ReadKey();
        }
    }
}
