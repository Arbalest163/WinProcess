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
        

        public static string Run(string?[] args)
        {
            string _filePath = @"C:\Users\User\source\repos\WinProcess\CalculatorTask3\bin\Debug\net5.0\CalculatorTask3.exe";
            var arguments = args?.Aggregate((prev, current) => prev + " " + current);
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = _filePath,
                    Arguments = arguments ?? ""
                }
            };

            process.Start();

            while (!process.WaitForExit(1000)) { }

            return process.ExitCode.ToString();
        }
    }
}
