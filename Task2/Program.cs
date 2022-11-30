using static System.Console;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Введите предложение (разделите слова пробелами) : ");
            WriteLine(Reverse(ReadLine()));
            ReadLine();
        }

        /// <summary>
        /// Метод, разворачивабщий порядок слов в предложении
        /// </summary>
        /// <param name="inputPhrase"></param>
        static string Reverse(string inputPhrase)
        {
            string resultString=null;
            for (int i = SplitText(inputPhrase).Length-1; i >=0; i--)
            {
                resultString += SplitText(inputPhrase)[i] + " ";
            }
            return resultString;
        }

        /// <summary>
        /// Метод, разделяющий введённый текст на слова
        /// </summary>
        /// <param name="enteredText"></param>
        /// <returns></returns>
        static string[] SplitText(string enteredText)
        {
            return enteredText.Split(' ');
        }
    }
}
