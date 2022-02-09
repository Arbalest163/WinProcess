using System.Diagnostics;

namespace WinProcess
{
    public class Task1
    {
        /// <summary>
        /// Запуск Задания 1
        /// </summary>
        /// <returns>Код завершения процесса</returns>
        public static string Run()
        {
            
            using var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe"
                }
            };
            process.Start();

            while (!process.WaitForExit(1000)) { }

            return process.ExitCode.ToString();
        }
    }
}
