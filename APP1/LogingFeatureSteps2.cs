using System;
using TechTalk.SpecFlow;

namespace App1.Spec
{
    [Binding]
    public class LogingFeatureSteps
    {
        [When(@"I fill in ""(.*)"" with (.*)")]
        public void WhenIFillInWith(string p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
