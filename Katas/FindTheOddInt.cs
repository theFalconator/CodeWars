using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class FindTheOddInt
    {
        public static int find_it(int[] seq)
        {
            return seq.GroupBy(i => i).Single(group => group.Count() % 2 != 0).Key;
        }
    }
}