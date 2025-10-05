using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace C_Project_ETA25.Pages;
public partial class HomePage 
{
    private IWebDriver _driver;

    
    public HomePage(IWebDriver driver)

    {
        _driver = driver;
    }

    public void Search(string search)
    {
       
        searchBox.SendKeys(search);
        searchBox.SendKeys(Keys.Enter);

    }



}
