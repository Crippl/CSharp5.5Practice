using static System.Console;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите предложение (разделите слова пробелами) : ");
            ShowSplittedText(SplitText(ReadLine()));
            ReadLine();
        }

        /// <summary>
        /// Метод, выводящий в консоль результат разделения на слова
        /// </summary>
        /// <param name="someText"></param>
        static void ShowSplittedText(string[] someWords)
        {
            foreach (var word in someWords)
            {
                WriteLine($" {word} ");
            }
        }

        /// <summary>
        /// Метод, разделяющий введённый текст на слова
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        static string[] SplitText(string enteredText)
        {
            return enteredText.Split(' ');
        }
    }
}
