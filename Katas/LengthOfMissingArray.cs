using System;
using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class LengthOfMissingArray
    {
        public static int GetLengthOfMissingArray(object[][] arrayOfArrays)
        {
            if (arrayOfArrays == null || arrayOfArrays.Length == 0)
                return 0;
            
            foreach (var array in arrayOfArrays)
            {
                if (array.Length == 0 || array.Equals(null))
                    return 0;
            }
            
            var lengths = arrayOfArrays.Select(array => array.Length).ToList();
            if (lengths.Count == 0)
                return 0;

            var allLengths = Enumerable.Range(lengths.Min(), lengths.Max());

            return allLengths.Except(lengths).First();
        }
    }
}