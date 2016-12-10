using System;

namespace ShippingContainerApp
{
    public class ShippingManifest
    {
        public int GetNumber(int number) =>
            Newtonsoft.Json.JsonConvert.DeserializeObject<int>($"{number}");
    }
}
