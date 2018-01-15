using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Greed
    {
        private static int Points(int die, int count)
        {
            switch (die)
            {
                case 1:
                    return count / 3 * 1000 + count % 3 * 100;
                case 5:
                    return count / 3 * 500 + count % 3 * 50;
                default:
                    return count / 3 * die * 100;
            }
        }

        public static int Score(int[] dice)
        {
            return dice
                .GroupBy(d => d)
                .Select(g => Points(g.Key, g.Count()))
                .Sum();
        }
    }
}