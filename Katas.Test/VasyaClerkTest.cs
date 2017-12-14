using System.Linq.Expressions;
using Xunit;
using static Katas.VasyaClerkKata;

namespace Katas.Test
{
    public class VasyaClerkTest
    {
        [Fact]
        public void CanSellTicketsAndGiveChange()
        {
            var people = new[] {25, 25, 50, 50};
            Assert.Equal("YES", Tickets(people));
        }

        [Fact]
        public void NotEnoughChange()
        {
            var people = new[] {25, 100};
            Assert.Equal("NO", Tickets(people));
        }
    }
}