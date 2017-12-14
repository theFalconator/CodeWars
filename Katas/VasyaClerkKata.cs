using System.Collections.Generic;

namespace Katas
{
    public static class VasyaClerkKata
    {
        public static string Tickets(int[] peopleInLine)
        {
            var change = new Dictionary<int, int>();

            change.Add(25, 0);
            change.Add(50, 0);
            change.Add(100, 0);


            foreach (var person in peopleInLine)
            {
                var changeNeeded = person - 25;
                switch (changeNeeded)
                {
                    // given 25 dollars
                    case 0:
                    {
                        change[25]++;
                    }
                        break;
                    // given 50 dollars
                    case 25:
                    {
                        if (change[25] > 0)
                        {
                            change[25]--;
                            change[50]++;
                        }
                    }
                        break;
                    // given 100 dollars
                    case 100:
                    {
                        if (change[25] > 0 && change[50] > 0)
                        {
                            change[25]--;
                            change[50]--;
                            change[100]++;
                        }
                    }
                        break;
                    default:
                        return "NO";
                }
            }

            return "YES";
        }
    }
}