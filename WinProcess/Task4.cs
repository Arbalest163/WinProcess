using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WinProcess
{
    public class Task4
    {
        public string FindWord { get; set; } = string.Empty;
        public string FilePath { get; set; } = string.Empty;

        /// <summary>
        /// Запуск задания 4
        /// </summary>
        /// <returns>Количество вхождений искомого сочетания в тексте</returns>
        public Task<int> RunAsync()
        {
            var fileText = File.ReadAllText(FilePath);

            var separators = new char[] { '.', '?', '!', ' ', ';', ':', ',' };

            string[] source = fileText.Split(separators, System.StringSplitOptions.RemoveEmptyEntries);

            return Task.Run(() => source.Where(word => word.ToLowerInvariant().Contains(FindWord.ToLowerInvariant())).Count());

        }
    }
}
