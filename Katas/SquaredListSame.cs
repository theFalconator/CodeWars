using System;
using System.Linq;

namespace Katas
{
    public static class SquaredListSame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null)
                return false;

            var sA = a.Select(i => i * i).OrderBy(i => i).ToList();
            var sB = b.OrderBy(i => i).ToList();
            return sA.SequenceEqual(sB);
            // return a.All(element => b.Contains(element * element));
        }
    }
}