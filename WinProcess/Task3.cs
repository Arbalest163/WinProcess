using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinProcess
{
    public class Task3
    {
        /// <summary>
        /// Запуск задания 3
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        public static Task Run(string?[] args)
        {
            return Task.Run(() => ProcessRun(args));
        }

        private static void ProcessRun(string?[] args)
        {
            try
            {
                string _filePath = $"..\\..\\..\\..\\CalculatorTask3\\bin\\Debug\\net5.0\\CalculatorTask3.exe";
                var arguments = args?.Aggregate((prev, current) => prev + " " + current) ?? string.Empty;
                using var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = _filePath,
                        Arguments = arguments
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
