using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            var frequency = new Dictionary<int, int>();

            foreach (var i in seq)
            {
                if (frequency.ContainsKey(i))
                {
                    frequency[i] += 1;
                }
                else
                {
                    frequency.Add(i, 1);
                }
            }

            return frequency.Keys.First(key => frequency[key] % 2 != 0);
        }
    }
}