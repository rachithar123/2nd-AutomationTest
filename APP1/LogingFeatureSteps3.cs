using System;
using TechTalk.SpecFlow;

namespace App1.Spec
{
    [Binding]
    public class LogingFeatureSteps
    {
        [Then(@"I should be on the users home page ""(.*)""")]
        public void ThenIShouldBeOnTheUsersHomePage(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
