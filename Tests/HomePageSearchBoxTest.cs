using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Project_ETA25.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace C_Project_ETA25.Tests;
public class HomePageSearchBoxTest : TestBasePage
{

    [Test]
    public void SearchBoxTest()
    {
        HomePage homePage = new HomePage(driver);
        homePage.Search("laptop");
        
        //Assert.That(driver.Url.Contains("laptop"));
    }
}
