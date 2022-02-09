using System.Diagnostics;
using System.Threading.Tasks;

namespace WinProcess
{
    public class Task2
    {
        private static Process? _process;
        /// <summary>
        /// Запуск Задания 1
        /// </summary>
        /// <returns>Код завершения процесса</returns>
        public static async Task<string> Run()
        {

            await Task.Run(ProcessRun);

            return _process?.ExitCode.ToString() ?? "";
        }

        public static void ProcessRun()
        {
            _process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe"
                }
            };
            _process.Start();

            while (!_process.WaitForExit(1000)) { }
        }

        public static void Kill()
        {
            _process?.Kill();
        }
    }
}
