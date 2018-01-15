using Xunit;
using static Katas.ReversedWords;
namespace Katas.Test
{
    public class ReversedWords
    {
        [Fact]
        public void BasicTests()
        {
            Assert.Equal("world! hello", ReverseWords("hello world!"));
            Assert.Equal("this like speak doesn't yoda", ReverseWords("yoda doesn't speak like this"));
            Assert.Equal("foobar", ReverseWords("foobar"));
            Assert.Equal("kata editor", ReverseWords("editor kata"));
            Assert.Equal("boat your row row row", ReverseWords("row row row your boat"));
        }
        
    }
}