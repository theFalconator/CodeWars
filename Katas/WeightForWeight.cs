using System.Collections.Generic;
using System.Linq;

namespace Katas
{
    public class WeightForWeight
    {
        public static string orderWeight(string s)
        {
            // split list into individual weights
            var weights = s.Split(' ');
            
            // Populate hashtable with weights and sorted weights
            var Dict = new Dictionary<string, int>();
            foreach (var weight in weights)
            {
                var sortedWeight = weight.Select(i => int.Parse(i.ToString())).Sum();
                if(!Dict.ContainsKey(weight))
                    Dict.Add(weight,sortedWeight);    
            }
            
            // Sort dictionary by value and grab only keys
            var sorted = weights.OrderBy(i => Dict[i]);
            // var sorted = Dict.OrderBy(i => i.Value).Select(x=>x.Key);
            // concatenate list into single string and return
            return string.Join(" ", sorted);
        }
    }
}