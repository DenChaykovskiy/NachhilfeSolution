using System;
using CSharp;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number what you want to execute...");
            Console.WriteLine("  1. Singleton");
            Console.WriteLine("  2. Abstract");
            Console.WriteLine("  3. Polymorphism");
            Console.WriteLine("  4. Ueberladen");
            Console.WriteLine("  5. Abstract Factory");
            Console.Write(" Your choice: ");


            var input = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine();


            switch (input.Key)
            {
                case ConsoleKey.D1:
                    var singleton = new SingletonUsage();
                    break;

                case ConsoleKey.D2:
                    var abstractUseCase = new AbstractUseCase();
                    break;

                case ConsoleKey.D3:
                    var polymorphism = new Polymorphism();
                    break;

                case ConsoleKey.D4:
                    var ueberladen = new UeberladenUseCase();
                    break;

                case ConsoleKey.D5:
                    var abstractFactoryUseCase = new AbstractFactoryUseCase();
                    break;

                default:
                    Console.WriteLine("NOTHING was selected to execute");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press any key to exit from Console App...");
            Console.ReadKey();
        }
    }
}
