using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Katas
{
    public class Multiples
    {
        public static int Solution(int value)
        {
            if (value == 0)
                return 0;

            return Enumerable.Range(1, value - 1).Where(i => i % 3 == 0 || i % 5 == 0).Sum();
        }
    }
}