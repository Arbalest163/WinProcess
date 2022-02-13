using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace WinProcess
{
    public class Task3
    {
        public static void Run(string?[] args)
        {
            try
            {
                string _filePath = $"..\\..\\..\\..\\CalculatorTask3\\bin\\Debug\\net5.0\\CalculatorTask3.exe";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
