using System;
using System.Collections.Generic;

namespace Katas
{
    public class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            var characters = new Dictionary<char, int>();
            
            var result = "";
            foreach (var letter in word.ToLower())
            {
                if (characters.ContainsKey(letter))
                {
                    characters[letter]++;
                }
                else
                {
                    characters[letter] = 1;
                }
            }

            foreach (var letter in word.ToLower())
            {
                if (characters[letter] <= 1)
                    result += "(";
                else
                {
                    result += ")";
                }
            }

            return result;
        }
    }
}