using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using MbUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;

namespace UnitTestProject1
{
    public class MainPage
    {
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            //PageFactory.InitElements(driver, this);
        }

        private IWebElement FooElement
        {
            get
            {
                return this.driver.FindElement(By.Id("//input[@name='q']")); //вказуємо де є поле на сторінці
            }
        }

        //[FindsBy(How = How.XPath, Using = "//input[@name='q']")]
        public IWebElement SearchField { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[@name='btnK']")] //вказуємо де є кнопка
        public IWebElement SearchButton { get; set; }

        public void Search(string text)
        {
            SearchField.SendKeys(text); //вводимо текст 
            SearchButton.Submit();//натискаємо кнопку
        }
    }
}
