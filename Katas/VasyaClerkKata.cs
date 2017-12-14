using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Katas
{
    public class VasyaClerkKata
    {
        public static string Tickets(int[] peopleInLine)
        {
            
            var change = new List<int>();
            
            
            foreach (var person in peopleInLine)
            {
                var needed = person - 25;
                if (needed == 0)
                {
                    change.Add(person);
                    continue;
                }
                // person needs change, do we have it?
                if (!change.Contains(needed))
                    return "NO";
                change.Add(person);

            }
            return "YES";
        }
    }
}