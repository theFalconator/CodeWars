using Xunit;
using static Katas.SquaredListSame;

namespace Katas.Test
{
    public class SquaredListSame
    {
        [Fact]
        public void SampleTest()
        {
            var a = new[] {121, 144, 19, 161, 19, 144, 19, 11};
            var b = new[] {11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19};

            Assert.Equal(true, comp(a, b));
        }
    }
}