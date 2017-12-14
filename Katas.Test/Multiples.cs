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
        }
    }
}