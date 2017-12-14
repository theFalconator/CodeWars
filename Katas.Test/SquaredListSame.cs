using Xunit;
using static Katas.SquaredListSame;

namespace Katas.Test
{
    public class SquaredListSame
    {
 
        [Fact]
        public void EmptyCase()
        {
            int[] a = { };
            int[] b = { };
            Assert.True(comp(a, b));
        }

        [Fact]
        public void NullCase()
        {
            Assert.False(comp(null, null));
        }

        [Fact]
        public void FalseCase()
        {
            var a = new int[] {122, 144, 19, 161, 19, 144, 19, 11};
            var b = new int[] {121, 14641, 20736, 361, 25921, 361, 20736, 361};
            Assert.False(comp(a, b));
        }

        [Fact]
        public void SampleTest()
        {
            var a = new[] {121, 144, 19, 161, 19, 144, 19, 11};
            var b = new[] {11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19};

            Assert.True(comp(a, b));
        }
    }
}