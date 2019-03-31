using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW {
    [Binding]
    public class steps {
        [Given(@"I have done some stuff")]
        public void GivenIHaveDoneSomeStuff() {
            Assert.AreEqual(true, false);
        }

        [Then(@"it might do other stuff")]
         public void ThenItMightDoOtherStuff()
         {
             ScenarioContext.Current.Pending();
         }

    }
    
}

