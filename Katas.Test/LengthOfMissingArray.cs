using Xunit;
using static Katas.LengthOfMissingArray;

namespace Katas.Test
{
    public class LengthOfMissingArray
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal(3, GetLengthOfMissingArray(new object[][] { new object[] { 1, 2 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 }} ));
            Assert.Equal(2, GetLengthOfMissingArray(new object[][] { new object[] { 5, 2, 9 }, new object[] { 4, 5, 1, 1 }, new object[] { 1 }, new object[] { 5, 6, 7, 8, 9 }} ));
            Assert.Equal(2, GetLengthOfMissingArray(new object[][] { new object[] { null }, new object[] { null, null, null } } ));
            Assert.Equal(5, GetLengthOfMissingArray(new object[][] { new object[] { 'a', 'a', 'a' }, new object[] { 'a', 'a' }, new object[] { 'a', 'a', 'a', 'a' }, new object[] { 'a' }, new object[] { 'a', 'a', 'a', 'a', 'a', 'a' }} ));
      
            Assert.Equal(0, GetLengthOfMissingArray(new object[][] { }));            
        }
    }
}