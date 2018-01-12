using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public static class Supermarket
    {
        public static long QueueTime(int[] customers, int n)
        {
            if (n == 1)
                return customers.Sum();

            if (n > customers.Length)
                return customers.Max();
            
            var q = new Queue<int>(customers);
            var times = new int[n];
            for (var i = 0; i < n-1; i++)
            {
                times[i] = 0;
            }

            while (q.Count > 0)
            {
                var minIndex = Array.IndexOf(times, times.Min());
                times[minIndex] += q.Dequeue();
            }

            return times.Max();
        }
    }
}