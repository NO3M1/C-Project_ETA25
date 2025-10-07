using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Project_ETA25.Drivers;
using C_Project_ETA25.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_Project_ETA25.Tests;
public class HomePageSearchBoxTest : DriverPage
{

    [Test]
    public void SearchBoxTest()
    {
        HomePage homePage = new HomePage(driver);
        homePage.Search("telefon mobil nokia 3210 4g 2024 scuba");
        Assert.That(driver.Title, Does.Contain("nokia 3210 4g 2024 scuba"));
        Thread.Sleep(3000);
    }

 
}
