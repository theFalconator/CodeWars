using Xunit;
using static Katas.PersistentBugger;

namespace Katas.Test
{
    public class PersistentBugger
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(3, Persistence(39));
            Assert.Equal(0, Persistence(4));
            Assert.Equal(2, Persistence(25));
            Assert.Equal(4, Persistence(999));
        }
    }
}