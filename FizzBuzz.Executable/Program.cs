using System;

namespace FizzBuzz.Executable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number to count up to:");
            var numberInput = Console.ReadLine();

#if VS2015
            var number = 0;
            if (int.TryParse(numberInput, out number))
            {
                Console.WriteLine($"You have chosen {number}");     // String interpolation - C# 6
                Console.WriteLine("Executing...");

                var results = FizzBuzzLogic.FizzBuzz(number);

                foreach (var result in results)
                    Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Input.  Closing program...");
                Environment.Exit(-100);
            }
#endif

#if VS2017
            if (int.TryParse(numberInput, out int number))          // Out variables - C# 7
            {
                Console.WriteLine($"You have chosen {number}");     // String interpolation - C# 6
                Console.WriteLine("Executing...");

                var results = FizzBuzzLogic.FizzBuzz(number);

                foreach (var result in results)
                    Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Invalid Input.  Closing program...");
                Environment.Exit(-100);
            }
#endif

            Console.WriteLine("Press any key to close...");
            Console.Read();
        }
    }
}
