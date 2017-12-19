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
                var times = customers.Skip(i).Take(n).ToArray();
                i += n;
                elapsedTime += times.Max();
            }

            return elapsedTime;
        }
    }
}