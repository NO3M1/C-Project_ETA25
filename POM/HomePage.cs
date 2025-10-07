using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Events;

namespace C_Project_ETA25.Pages;
public partial class HomePage
{
    private IWebElement searchBox => _driver.FindElement(By.Id("keyword"));
    

}
