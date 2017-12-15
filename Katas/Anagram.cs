using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Katas
{
    public static class Anagram
    {
        private static Dictionary<char, int> CharFrequency(string word)
        {
            var result = new Dictionary<char, int>();
            foreach (var c in word)
            {
                if (result.ContainsKey(c))
                {
                    result[c]++;
                }

                else
                {
                    result.Add(c, 1);
                }
            }

            return result;
        }

        public static List<string> Anagrams(string word, List<string> words)
        {
            var d = CharFrequency(word);
            return words.Where(w => CharFrequency(w).Count == d.Count && !d.Except(CharFrequency(w)).Any()).ToList();
        }
    }
}