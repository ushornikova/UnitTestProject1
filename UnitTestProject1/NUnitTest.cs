using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;


namespace GoogleTestProject
{
    public class GooglePage
    {
        [Test]
        public void UlianaTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");

            MainPage mainPage = new MainPage(driver);

            mainPage.Search("BrainStorm");

            IWebElement block = driver.FindElement(By.Id("rhs_block"));
            Assert.True(block.Displayed);
            driver.Quit();
        }
    }
}