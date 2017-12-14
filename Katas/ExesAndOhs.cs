using System.Linq;

namespace Katas
{
    public static class ExesAndOhs
    {
        public static bool XO(string input)
        {
            var xs = input.Count(c => c == 'o' || c == 'O');
            var os = input.Count(c => c == 'x' || c == 'X');
            return xs == os;
        }
    }
}