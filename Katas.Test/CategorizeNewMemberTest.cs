using Xunit;
using static Katas.CategorizeNewMemberKata;

namespace Katas.Test
{
    
    public class CategorizeNewMemberTest
    {
        [Fact]
        public void SampleTest()
        {
            Assert.Equal(new[] { "Open", "Senior", "Open", "Senior" }, OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } }));
            Assert.Equal(new[] { "Open", "Open", "Open", "Open" }, OpenOrSenior(new[] { new[] { 3, 12 }, new[] { 55, 1 }, new[] { 91, -2 }, new[] { 54, 23 } }));
            Assert.Equal(new[] { "Senior", "Open", "Open", "Open" }, OpenOrSenior(new[] { new[] { 59, 12 }, new[] { 45, 21 }, new[] { -12, -2 }, new[] { 12, 12 } }));    
        }
        
    }
}