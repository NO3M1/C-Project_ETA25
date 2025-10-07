using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Project_ETA25.Drivers;
using C_Project_ETA25.Enums;
using OpenQA.Selenium;

namespace C_Project_ETA25.Pages;
public class LoginPage
{

    private IWebDriver _driver;


    public IWebElement iconUser => _driver.FindElement(By.CssSelector(".iconUser"));
    

    public IList<IWebElement> logInMenuOptions => _driver.FindElements(By.CssSelector("div.myAccountMenu a"));

    public IWebElement NumeFillIn => _driver.FindElement(By.Id("firstname"));
    public IWebElement PrenumeFillIn => _driver.FindElement(By.Id("lastname"));
    public IWebElement EmailFillIn => _driver.FindElement(By.XPath("//input[@name='email_address']"));
    public IWebElement TelephoneFillIn => _driver.FindElement(By.Id("telephone"));
    public IWebElement AddressFillIn => _driver.FindElement(By.Id("street_address"));
    public IWebElement JudetDropDown => _driver.FindElement(By.Id("entry_suburb"));  // cluj text
                                                                                     //public IWebElement TermeniConditiiCheckBox => _driver.FindElement(By.Id("noidea"));
    public IWebElement termeniiCheckbox => _driver.FindElement(By.XPath("//input[@type='checkbox' and @name='termeni']"));
    public IWebElement SubmitButton => _driver.FindElement(By.XPath("//button[@class='btn btn-special']"));

    public IWebElement ConecteazaTeCard => GetCard("Conecteaza-te");
    public IWebElement ContNouCard => GetCard("Cont nou");
    public IWebElement AmUitatParolaCard => GetCard("Am uitat parola");
    public IWebElement CumComandCard => GetCard("Cum comand?");
    public IWebElement ServiceAndGarantiiCard => GetCard("Service & Garantii");
    public IWebElement ReturCard => GetCard("Retur");

    //public void AccessContNouPage() => ContNouCard.Click();
  
  
    private IWebElement GetCard(string loginPageOptions)
    {
        //return _driver.FindElement(By.XPath($"//div[@class='myAccountMenu']//*[text()='Cont nou']"));
        return _driver.FindElement(By.XPath($"//div[@class='myAccountMenu']//*[text()='{loginPageOptions}']"));
    }


    public LoginPage(IWebDriver driver)
    {
        _driver = driver;
    }

    public void LogInContNou()
    {
        iconUser.Click();
        //logInMenuOptions[1].Click();
        AccessUserDropDown(LoginPageOptions.ContNou);



    }

    public void AccessUserDropDown(LoginPageOptions loginPageOptions)
    {
        switch (loginPageOptions)
        {
            case LoginPageOptions.ConecteazaTe:
                GetCard("Conecteaza-te").Click();
                break;
            case LoginPageOptions.ContNou:
                GetCard("Cont nou").Click();
                break;
            case LoginPageOptions.AmUitatParola:
                GetCard("Am uitat parola").Click();
                break;
            case LoginPageOptions.CumComand:
                GetCard("Cum comand?").Click();
                break;
            case LoginPageOptions.ServiceAndGarantii:
                GetCard("Service & Garantii").Click();
                break;
            case LoginPageOptions.Retur:
                GetCard("Retur").Click();
                break;
            default:
                throw new ArgumentException("Non existing value!");
        }
    }


}
