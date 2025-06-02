using System; // not needed due to implicit using enabled. 

namespace ConsoleAppTest.Services
{
    public class GreetingService : IGreetingService
    {
        public void Greet(string name)
        {
            System.Console.WriteLine($"Hello, {name}!");
        }
    }
}