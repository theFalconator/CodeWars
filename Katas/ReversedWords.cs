using System;
using System.Linq;

namespace Katas
{
    public class ReversedWords
    {
        public static string ReverseWords(string str)
        {
            var words = str.Split(' ');
            return string.Join(" ", words.Reverse());
        }
    }
}