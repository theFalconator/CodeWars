using Xunit;
using static Katas.FindTheOddInt;

namespace Katas.Test
{
    public class FindTheOddInt
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(5, find_it(new[] { 20,1,-1,2,-2,3,3,5,5,1,2,4,20,4,-1,-2,5 }));
        }
    }
}