using System;

namespace Digits_of_e
{
    class Program
    {
        static void Main()
        {
            const int MAX = 14;
            int digits;

            do
            {
                Console.WriteLine();
                Console.WriteLine("Enter digits of e to print (" + MAX + " or less)");

                if (int.TryParse(Console.ReadLine(), out digits))
                {
                    if (digits > MAX)
                    {
                        Console.WriteLine(Math.Round(Math.E, MAX));
                    }
                    else if (digits < 0)
                    {
                        Console.WriteLine(Math.Round(Math.E, 0));
                    }
                    else
                    {
                        Console.WriteLine(Math.Round(Math.E, digits));
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Entry");
                }

                Console.WriteLine("Press any key to continue or 'Esc' to exit program");

            } while (Console.ReadKey().Key != ConsoleKey.Escape);

        }
    }
}
