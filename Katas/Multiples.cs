using System.Linq;


namespace Katas
{
    public class Multiples
    {
        public static int Solution(int value)
        {
            
            return value == 0 ? 0 : Enumerable.Range(1, value - 1).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}