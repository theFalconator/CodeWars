using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class PersistentBugger
    {
        public static IEnumerable<int> SplitIntoDigits(long n)
        {
            var s = n.ToString();
            return s.Select(digit => int.Parse(digit.ToString()));
        }
        public static int Persistence(long n)
        {
            if (n < 10)
                return 0;
            
            
            var result = SplitIntoDigits(n);
            var product = result.Aggregate(1, (a, b) => a * b);
            var count = 1;
            while (product > 9)
            {
                result = SplitIntoDigits(product);
                count++;
                product = result.Aggregate(1, (a, b) => a * b);
            }
            return count;
        }
    }
}