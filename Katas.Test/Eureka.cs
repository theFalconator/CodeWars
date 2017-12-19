using System.Linq;
using Xunit;
using static Katas.Eureka;

namespace Katas.Test
{
    public class Eureka
    {
        [Fact]
        public void SingleDigit()
        {
            Assert.Equal(SumDigPow(1, 10), new long[] {1, 2, 3, 4, 5, 6, 7, 8, 9});
        }
    }
}