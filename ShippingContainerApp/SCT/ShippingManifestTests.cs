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
            Assert.Equal(42, new ShippingManifest().GetNumber(42));
        }
    }
}
