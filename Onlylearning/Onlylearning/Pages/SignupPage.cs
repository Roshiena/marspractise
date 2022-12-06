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
    public class SignupPage
    {
           

            [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Join')]")]
            public IWebElement joinButton;


            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]")]
            public IWebElement firstNamebox;

            [FindsBy(How = How.XPath, Using = "input[placeholder='Last name']")]
            public IWebElement lastNamebox;

            [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
            public IWebElement emailId;

            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]")]
            public IWebElement passwordButton;

            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]")]
            public IWebElement passwordConfirm;

            [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/input[1]")]
            public IWebElement agreeTerms;

            [FindsBy(How = How.XPath, Using = "//div[@id='submit-btn']")]
            public IWebElement submitButton;

            





            public void SignUp(IWebDriver driver)
            {

                 Thread.Sleep(2000);
                 PageFactory.InitElements(driver, this);
                 joinButton.Click();

                 firstNamebox.Click();
                 string firstName = ExcelReader.ReadData(1, "Firstname");
                 firstNamebox.SendKeys(firstName);

                 lastNamebox.Click();
                 string lastName = ExcelReader.ReadData(1, "Lastname");
                 lastNamebox.SendKeys(lastName);

                 emailId.Click();
                 string emailAddress = ExcelReader.ReadData(1, "Email");
                 emailId.SendKeys(emailAddress);

                 passwordButton.Click(); 

                 string passWord = ExcelReader.ReadData(1, "Password");
                 passwordButton.SendKeys(passWord);

                 passwordConfirm.Click();    

                 string passWordConfirm = ExcelReader.ReadData(1, "ConfirmPassword");
                 passwordConfirm.SendKeys(passWordConfirm);

                 agreeTerms.Click();
                 submitButton.Click();

            }

    }

 }


