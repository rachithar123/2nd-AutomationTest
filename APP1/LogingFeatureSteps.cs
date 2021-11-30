using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace App1.Spec
{
    [Binding]
    public class LogingFeatureSteps
    {
        string p0;
        string p1;
        int p2;
        IWebDriver browser;
        IWebDriver driver;

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            browser = new ChromeDriver();
            browser.Url = "http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f";
        }
        
        [When(@"I fill in ""(.*)"" with ""(.*)""")]
        public void WhenIFillInWith(string p0, string p1)
        {
            IWebElement usernameTextbox= driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys(p1);
        }
        
        [When(@"I fill in ""(.*)"" with ""(.*)""")]
        public void WhenIFillInWith(string p0, int p2)
        {
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys(p2);
        }
        
        [When(@"I press ""(.*)""")]
        public void WhenIPress(string p0)
        {
            IWebElement login = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
           login.Click();
        }
        
        [Then(@"I should be on the users home page ""(.*)""")]
        public void ThenIShouldBeOnTheUsersHomePage(string p0)
        {
           Console.WriteLine(driver.FindElement(By.XPath("/html/body/div[3]/div/a")));
        }
        
        
    }
}
