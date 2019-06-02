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

namespace UnitTestProject1
{
    public class MyPage
    {
        [Test]
        public void Ffff()
        {
            IWebDriver driver = new ChromeDriver(); //викликали хром
            driver.Navigate().GoToUrl("http://google.com"); //вводимо урл

            /*
            IWebElement element = driver.FindElement(By.XPath("//input[@name='q']"));
            element.SendKeys("BrainStorm");
            IWebElement button = driver.FindElement(By.XPath("//input[@name='btnK']"));
            button.Submit();
            */
            MainPage mainPage = new MainPage(driver);           

            mainPage.SearchField.SendKeys("BrainStorm"); //шукаємо по слову
            mainPage.SearchButton.Submit(); //натискаємо кнопку 

            //mainPage.Search("BrainStorm");

            IWebElement block = driver.FindElement(By.Id("rhs_block"));//шукаємо елемент, блок на сторнці
            Assert.True(block.Displayed); //перевіряємо чи той елемент відображається
            driver.Quit();//закриваємо бровзер
        }
    }
}