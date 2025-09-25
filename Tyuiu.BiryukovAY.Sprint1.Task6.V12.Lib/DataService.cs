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

        string[] words = text.Split(' ');

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