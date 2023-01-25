using AventStack.ExtentReports;
using NUnit.Framework;
using Onlylearning.Input;
using Onlylearning.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Pages
{
    public class LoginPage : CommonDriver
    {


        [FindsBy(How = How.XPath, Using = "//*[@id=\"home\"]/div/div/div[1]/div/a")]
        public IWebElement signIn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]
        public IWebElement userName;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[2]/input")]
        public IWebElement passWord;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        public IWebElement loginButton;


        public void LoginStep()
        {
            PageFactory.InitElements(driver, this);
            driver.Navigate().GoToUrl(LoginCredential.string3);

            try
            {
                signIn.Click();
                userName.SendKeys(LoginCredential.string1);
                passWord.SendKeys(LoginCredential.string2);
                loginButton.Click();
                Wait.WaitToBeClickable(driver, "XPath", "//a[contains(text(),'Share Skill')]", 10);
            }
            catch (Exception ex)
            {
                test = extentreportobj.CreateTest("Login Test", "Testing Login");
                test.Log(Status.Fail, "Test failed");
                ClickScreenshot.LoginScreenShot();
                Assert.Fail("Unable to launch Mars portal", ex.Message);
                throw;
            }



        }
    }
}



