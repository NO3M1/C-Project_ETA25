using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_Project_ETA25.Drivers;
public class DriverPage 
{
    public IWebDriver driver  { get; private set; }


    [SetUp]
    public void InitializeBrowser()
    {
        driver = new ChromeDriver();
        driver.Manage().Window.Maximize();
        driver.Navigate().GoToUrl("https://cel.ro");
    }


    [TearDown]
    public void TearDown()
    {
        driver.Close();
        driver.Dispose();
       
    }
}

