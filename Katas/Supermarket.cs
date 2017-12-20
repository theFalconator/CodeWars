using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class Supermarket
    {
        public static long QueueTime(int[] customers, int n)
        {
            var elapsedTime = 0;
            
            if (n == 1)
                return customers.Sum();
            
            var i = 0;

            while (i < customers.Length)
            {
                IEnumerable<int> times = i+n-1 > customers.Length 
                    ? customers.Skip(i).Take(customers.Length).ToArray() 
                    : customers.Skip(i).Take(n-1).ToArray();
                i += n;
                elapsedTime += times.Max();
            }

            return elapsedTime;
        }
    }
}