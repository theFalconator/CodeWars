using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Greed
    {
        private static bool KeepScoring(IEnumerable<int> rolls)
        {
            var enumerable = rolls.ToList();
            return enumerable.Count(i => i == 1) >= 1
                   || enumerable.Count(i => i == 5) >= 1
                   || enumerable.Count(i => i == 1) == 3
                   || enumerable.Count(i => i == 6) == 3
                   || enumerable.Count(i => i == 5) == 3
                   || enumerable.Count(i => i == 4) == 3
                   || enumerable.Count(i => i == 3) == 3
                   || enumerable.Count(i => i == 2) == 3;
        }

        public static int Score(int[] dice)
        {
            var sum = 0;

            var rolls = dice.ToList();
            while (KeepScoring(rolls))
            {
                if (rolls.Count(i => i == 1) == 3)
                {
                    sum += 1000;
                    rolls.Remove(1);
                    rolls.Remove(1);
                    rolls.Remove(1);
                }


                if (rolls.Count(i => i == 6) == 3)
                {
                    sum += 600;
                    rolls.Remove(6);
                    rolls.Remove(6);
                    rolls.Remove(6);
                }

                if (rolls.Count(i => i == 5) == 3)
                {
                    sum += 500;
                    rolls.Remove(5);
                    rolls.Remove(5);
                    rolls.Remove(5);
                }

                if (rolls.Count(i => i == 4) == 3)
                {
                    sum += 400;
                    rolls.Remove(4);
                    rolls.Remove(4);
                    rolls.Remove(4);
                }

                if (rolls.Count(i => i == 3) == 3)
                {
                    sum += 300;
                    rolls.Remove(3);
                    rolls.Remove(3);
                    rolls.Remove(3);
                }

                if (rolls.Count(i => i == 2) == 3)
                {
                    sum += 200;
                    rolls.Remove(2);
                    rolls.Remove(2);
                    rolls.Remove(2);
                }

                if (rolls.Count(i => i == 1) < 3 && rolls.Count(i => i == 1) > 0)
                {
                    sum += 100;
                    rolls.Remove(1);
                }

                if (rolls.Count(i => i == 5) < 3 && rolls.Count(i => i == 5) > 0)
                {
                    sum += 50;
                    rolls.Remove(5);
                }
            }

            return sum;
        }
    }
}