using System.Linq;

namespace Katas
{
    public static class SquaredListSame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a == null || b == null || a.Length < 1 || b.Length < 1)
                return false;

            return a.All(element => b.Contains(element * element));
        }
    }
}