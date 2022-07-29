using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class SeleniumTest1Test
{
    private IWebDriver driver;
    public IDictionary<string, object> vars { get; private set; }
    private IJavaScriptExecutor js;
    [SetUp]
    public void SetUp()
    {
        driver = new ChromeDriver();
        js = (IJavaScriptExecutor)driver;
        vars = new Dictionary<string, object>();
    }
    [TearDown]
    protected void TearDown()
    {
        driver.Quit();
    }
    [Test]
    public void seleniumTest1()
    {
        driver.Navigate().GoToUrl("https://localhost:7027/");
        driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
        driver.FindElement(By.LinkText("All Products")).Click();
        driver.FindElement(By.LinkText("Add to cart")).Click();
        driver.FindElement(By.CssSelector(".col-4:nth-child(2) .btn")).Click();
        driver.FindElement(By.CssSelector(".col-4:nth-child(3) .btn")).Click();
        driver.FindElement(By.LinkText("View Cart")).Click();
        driver.FindElement(By.LinkText("+")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-info")).Click();
        driver.FindElement(By.CssSelector("tr:nth-child(3) .btn-danger")).Click();
        driver.FindElement(By.CssSelector(".btn-danger:nth-child(1)")).Click();
    }
}
