using System;
using System.Linq;

namespace Katas
{
    public class ShortestWordKata
    {
        public static int FindShort(string words)
        {
            return words.Split(' ').OrderByDescending(word => word.Length).Last().Length;
        }
    }
}