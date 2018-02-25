using System.Linq;
using Xunit;

namespace Katas.Test
{
    public class WeightSortTests
    {
        [Fact]
        public void SplitIntoDigits()
        {
            const string result = "12345";
            var nums = result.Select(i => int.Parse(i.ToString()));
            Assert.Equal(new[] {1,2,3,4,5}, nums);
        }
        
        [Fact]
        public void SampleTest()
        {
            Assert.Equal("2000 103 123 4444 99", WeightForWeight.orderWeight("103 123 4444 99 2000"));
            Assert.Equal("11 11 2000 10003 22 123 1234000 44444444 9999", WeightForWeight.orderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));
        }
        
    }
}