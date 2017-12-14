using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Multiples
    {
        private static readonly IEnumerable<int> multiples = new[] {3, 5};

        public static int Solution(int value)
        {
            return Enumerable.Range(1, value-1).Sum(i => multiples.Where(m => i % m == 0).Sum(m => i));
        }
    }
}