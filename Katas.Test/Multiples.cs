using Xunit;
using static Katas.Multiples;

namespace Katas.Test
{
    public class Multiples
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(23, Solution(10));
            Assert.Equal(78, Solution(20));
            Assert.Equal(9168, Solution(200));
            Assert.Equal(0, Solution(0));
        }
    }
}