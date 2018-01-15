using Xunit;
using static Katas.Greed;

namespace Katas.Test
{
    public class Greed
    {
        [Fact]
        public void ShouldBeWorthless()
        {
            Assert.Equal(0, Score(new[] {2, 3, 4, 6, 2}));
        }

        [Fact]
        public void ShouldValueTriplets()
        {
            Assert.Equal(400, Score(new[] {4, 4, 4, 3, 3}));
        }

        [Fact]
        public void ShouldValueMixedSets()
        {
            Assert.Equal(450, Score(new[] {2, 4, 4, 5, 4}));
        }

        [Fact]
        public void Examples()
        {
            Assert.Equal(250, Score(new[] {5, 1, 3, 4, 1}));
        }
    }
}