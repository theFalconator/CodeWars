using System;
using Xunit;
using static Katas.FriendOrFoeKata;

namespace Katas.Test
{
    public class Tests
    {
        [Fact]
        public void SampleTest()
        {
            string[] expected = { "Ryan", "Mark" };
            string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
            
            Assert.Equal(expected, FriendOrFoe(names));
        }
    }
}