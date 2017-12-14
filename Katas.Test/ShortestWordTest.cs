using System.Linq;
using Xunit;
using static Katas.ShortestWordKata;

namespace Katas.Test
{
    public class ShortestWordTest
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(3, FindShort("bitcoin take over the world maybe who knows perhaps"));
            Assert.Equal(3, FindShort("turns out random test cases are easier than writing out basic ones"));              
        }

        [Fact]
        public void SplitOnSpaces()
        {
            var words = new[] {"one", "two", "three"};
            const string s = "one two three";
            
            Assert.Equal(s.Split(' '), words);
        }

        [Fact]
        public void LinqFirst()
        {
            const string s = "two three";
            var words = s.Split(' ');
            
            Assert.Equal("two", words.OrderBy(word => word.Length).First());
        }
    }
}