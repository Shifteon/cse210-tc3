using System;

namespace cse210_tc3
{
    class Program
    {
        static void DisplayGreetingMosiah()
        {
            Console.WriteLine("Howdy, I'm Mosiah");
        }
        
        static void DisplayGreetingBen()
        {
            Console.WriteLine("Hello from Ben!");
        }

        static void DisplayGreetingMichael()
        {
            Console.WriteLine("Hello, I'm Michael!");
        }

        static void DisplayGreetingSasha()
        {
            Console.WriteLine("Sasha says Hello");
        }

        static void Main(string[] args)
        {
            DisplayGreetingMosiah();
            DisplayGreetingBen();
            DisplayGreetingMichael();
            DisplayGreetingSasha();
        }
    }
}
