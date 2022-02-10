using System;

namespace CalculatorTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args.Length < 3)
                {
                    throw new Exception("Аргументы не переданы");
                }

                if (!Double.TryParse(args[0], out var value1)) throw new Exception("Аргументы не распознаны");
                if (!Double.TryParse(args[1], out var value2)) throw new Exception("Аргументы не распознаны");

                var result = args[2] switch
                {
                    "+" => value1 + value2,
                    "-" => value1 - value2,
                    "*" => value1 * value2,
                    "/" => value1 / value2,
                    _ => 0
                };

                Console.WriteLine($"{value1} {args[2]} {value2} = {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}
