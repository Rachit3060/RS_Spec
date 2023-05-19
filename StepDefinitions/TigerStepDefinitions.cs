using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class TigerStepDefinitions
    {
        private IWebDriver driver;
        //Miss 1 - driver ref
        public TigerStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"Open the browser")]
        public void GivenOpenTheBrowser()
        {
            //driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
        }

        [When(@"Enter YouTube URL")]
        public void WhenEnterYouTubeURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(3000);
        }

        [Then(@"Search for the Tiger")]
        public void ThenSearchForTheTiger()
        {
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys("Tiger");
            driver.FindElement(By.XPath("//*[@name='search_query']")).SendKeys(Keys.Enter);
            Thread.Sleep(3000);
        }
    }
}
