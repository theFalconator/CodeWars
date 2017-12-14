using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public static class FriendOrFoeKata
    {
        public static IEnumerable<string> FriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4);
        }
    }
}