using tyuiu.cources.programming.interfaces.Sprint1;
using static System.Net.Mime.MediaTypeNames;
namespace Tyuiu.BiryukovAY.Sprint1.Task6.V12.Lib
{
    public class DataService : ISprint1Task6V12
    {
        public bool CheckLastWordRepetiton(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
                return false;

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length < 2)
                return false;

            string lastWord = words[words.Length - 1].ToLower();

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (words[i].ToLower() == lastWord)
                    return true;
            }

            return false;
        }
    }
}