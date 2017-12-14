using System.Collections.Generic;

namespace Katas
{
    public static class CategorizeNewMemberKata
    {
        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            var result = new List<string>();
            foreach (var row in data)
            {
                var age = row[0];
                var handicap = row[1];

                if (age >= 55 && handicap > 7)
                    result.Add("Senior");
                else
                {
                    result.Add("Open");
                }
            }

            return result;
        }
    }
}