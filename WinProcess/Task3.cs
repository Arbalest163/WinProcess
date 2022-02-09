using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinProcess
{
    public class Task3
    {
        

        public static string Run()
        {
            string _filePath = @"C:\Users\User\source\repos\WinProcess\CalculatorTask3\bin\Debug\net5.0\CalculatorTask3.exe";
            IEnumerable<string> args = new List<string> { "Аргумент1", "Аргумент2", "Аргумент3" };

            using var process = new Process();

            process.Start(_filePath, args);

            while (!process.WaitForExit(1000)) { }

            return process.ExitCode.ToString();
        }
    }
}
