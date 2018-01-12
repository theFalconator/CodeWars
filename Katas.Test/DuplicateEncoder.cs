using Xunit;
using static Katas.DuplicateEncoder;
namespace Katas.Test
{
    
    public class DuplicateEncoder
    {
        [Fact]
        public void NoDuplicates()
        {
            Assert.Equal("(((", DuplicateEncode("din"));
        }
        
        [Fact]
        public void BasicTests()
        {
            
            Assert.Equal("()()()", DuplicateEncode("recede"));
            Assert.Equal(")())())", DuplicateEncode("Success"));
            Assert.Equal("))((", DuplicateEncode("(( @"));
        }
        
    }
}