using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class PersistentBugger
    {
        
        public static int Persistence(long n)
        {
            var count = 0;
            while (n > 9)
            {
                count++;
                n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
            }

            return count;
        }
    }
}