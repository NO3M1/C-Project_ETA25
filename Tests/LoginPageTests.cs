using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_Project_ETA25.Drivers;
using C_Project_ETA25.Pages;
using NUnit.Framework;

namespace C_Project_ETA25.Tests;
public class LoginPageTests : DriverPage
{
    [Test]
    public void LogInWithInvalidCredentials()
    {
        //
    }

    [Test]
    public void LogInWithValidCredentials()
    {
        //
    }

    [TestCase("Noemi", "Nooooooo", "blavla@yahoo.com", "0745857489", "Address1", "Cluj")]
    public void CreateNewAccount(string nume, string prenume, string email, string telephone, string address, string judet)
    {
      
        LoginPage logIn = new LoginPage(driver);
        HelperMethods.JavascripHelper js = new HelperMethods.JavascripHelper(driver);


        logIn.LogInContNou();
        logIn.NumeFillIn.SendKeys(nume);
        logIn.PrenumeFillIn.SendKeys(prenume);
        logIn.EmailFillIn.SendKeys(email);
        logIn.TelephoneFillIn.SendKeys(telephone);
        logIn.AddressFillIn.SendKeys(address);
        logIn.JudetDropDown.SendKeys(judet);

        js.Scroll(0, 400);

        logIn.termeniiCheckbox.Click();
        js.Scroll(0, 900);

        logIn.SubmitButton.Click();

        Assert.That(driver.Title, Does.Contain("Contul tau a fost creat !"));

        Thread.Sleep(3000);
    }

}
