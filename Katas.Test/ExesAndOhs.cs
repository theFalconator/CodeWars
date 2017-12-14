using System.Diagnostics;
using Xunit;
using static Katas.ExesAndOhs;

namespace Katas.Test
{
    public class ExesAndOhs
    {
        [Fact]
        public void ExampleTests()
        {
            
            Assert.Equal(true, XO("xo"));
            Assert.Equal(true, XO("xxOo"));
            Assert.Equal(false, XO("xxxm"));
            Assert.Equal(false, XO("Oo"));
            Assert.Equal(false, XO("ooom"));
        }
    }
}