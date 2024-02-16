
namespace GangOf4Patterns.Creational
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instance = new(() => new Logger());

        public static Logger Instance => _instance.Value;
        private Logger() {}

        public void Log(string message)
        {
            Console.WriteLine($"Logger message:{message}");
        }
    }

}
