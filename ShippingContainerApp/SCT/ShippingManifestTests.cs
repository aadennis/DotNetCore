using System;
using Xunit;
using ShippingContainerApp;

namespace ShippingContainerApp
{
    public class ShippingManifestTests
    {
        [Fact]
        public void Test1() 
        {
            Assert.True(true);
        }

        [Fact]
        public void ThingGetsObjectValFromNumber()
        {
            Assert.Equal(423, new ShippingManifest().GetNumber(42));
        }
    }
}
