using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using MbUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Remote;

namespace GoogleTestProject
{
    public class MainPage
    {     
        private readonly RemoteWebDriver _driver;
        //private IWebDriver driver;
        public MainPage(RemoteWebDriver driver) => _driver = driver;

        //public MainPage(IWebDriver driver)
        //{
        //    this.driver => driver;
        //}
        IWebElement SearhField => _driver.FindElementByName("q");

        IWebElement SearhButton => _driver.FindElementByName("btnK");

        public void Search(string text)
        {
            SearhField.SendKeys(text);
            SearhButton.Submit();
        }
    }
}