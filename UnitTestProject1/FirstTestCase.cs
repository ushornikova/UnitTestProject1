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
        //private IWebDriver driver;

        //public MainPage(IWebDriver driver)
        //{
        //    this.driver = driver;
        //    PageFactory.InitElements(driver, this);
        //}

        //[FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        //public IWebElement SearchField { get; set; }

        //[CacheLookup]
        //[FindsBy(How = How.XPath, Using = "//input[@name='btnK']")]
        //public IWebElement SearchButton { get; set; }


        private readonly RemoteWebDriver _driver;
        public MainPage(RemoteWebDriver driver) => _driver = driver;

        IWebElement SearhField => _driver.FindElementByName("q");

        IWebElement SearhButton => _driver.FindElementByName("btnK");


        public void Search(string text)
        {
            SearhField.SendKeys(text);
            SearhButton.Submit();
        }
    }
}