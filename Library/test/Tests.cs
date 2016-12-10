using System;
using Xunit;
using ClassLibrary;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1() 
        {
            Assert.True(true);
        }

        [Fact]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.Equal(423, new Thing().Get(42));
        }
    }
}
