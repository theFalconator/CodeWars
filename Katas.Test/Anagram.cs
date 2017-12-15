using System.Collections.Generic;
using Xunit;
using static Katas.Anagram;

namespace Katas.Test
{
    public class Anagram
    {
        [Fact]
        public void SingleCharacter()
        {
            Assert.Equal(new List<string> {"a"}, Anagrams("a", new List<string> {"a", "b", "c", "d"}));
            
        }

        [Fact]
        public void KnownAnagrams()
        {
            Assert.Equal(new List<string> {"carer", "arcre", "carre"}, Anagrams("racer", new List<string> {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"}));
        }
    }
}