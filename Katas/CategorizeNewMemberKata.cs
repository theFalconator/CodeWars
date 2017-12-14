using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public static class CategorizeNewMemberKata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
        }
    }
}