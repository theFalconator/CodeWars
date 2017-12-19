using Xunit;
using static Katas.Supermarket;

namespace Katas.Test
{
    public class Supermarket
    {
        [Fact]
        public void EmptyQueueReturnsZero()
        {
            Assert.Equal(0, QueueTime(new int[] {}, 1));
        }

        [Fact]
        public void SingleTill()
        {
            Assert.Equal(10, QueueTime(new[] {1,2,3,4}, 1));
        }

        [Fact]
        public void MultipleTills()
        {
            Assert.Equal(9, QueueTime(new[] { 2, 2, 3, 3, 4, 4 }, 2));
        }

        [Fact]
        public void MoreTillsThanCustomers()
        {
            Assert.Equal(5, QueueTime(new[] {1,2,3,4,5}, 100));
        }
    }
}