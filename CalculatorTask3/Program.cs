using System;

namespace CalculatorTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                Console.WriteLine("Аргументы не переданы");
                return;
            }

            double value1 = 0;
            double value2 = 0;

            bool isValid = Double.TryParse(args[0], out value1) && Double.TryParse(args[1], out value2);

            if (!isValid)
            {
                Console.WriteLine("Аргументы не распознаны");
            }

            var result = args[2] switch
            {
                "+" => value1 + value2,
                "-" => value1 - value2,
                "*" => value1 * value2,
                "/" => value1 / value2,
                _ => 0
            };

            Console.WriteLine($"{value1} {args[2]} {value2} = {result}");

            Console.ReadLine();
        }
    }
}
