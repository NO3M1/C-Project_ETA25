using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace C_Project_ETA25.HelperMethods;
public class JavascripHelper
{
    private IWebDriver _driver;
    private IJavaScriptExecutor _javascriptExecutor;
    public JavascripHelper(IWebDriver driver)
    {
        _driver = driver;
        _javascriptExecutor = (IJavaScriptExecutor)driver;
    }

    public void Scroll(int x, int y)
    {
        _javascriptExecutor.ExecuteScript($"window.scrollTo({x}, {y});");
    }
}


