using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.BiryukovAY.Sprint1.Task6.V12.Lib
{
    public bool CheckLastWordRepetition(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return false;

        string[] words = text.Split(' ', System.StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
            return false;

        string lastWord = CleanWord(words[^1]);

        if (string.IsNullOrEmpty(lastWord))
            return false;

        for (int i = 0; i < words.Length - 1; i++)
        {
            string currentWord = CleanWord(words[i]);
            if (currentWord.Equals(lastWord, System.StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }

    private string CleanWord(string word)
    {
        return new string(word.Where(c => !char.IsPunctuation(c)).ToArray());
    }
}
}