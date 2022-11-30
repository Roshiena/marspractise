using NUnit.Framework;
using Onlylearning.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Pages
{
    public class ListingsPage 
    {
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[1]")]
        public IWebElement viewIcon;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[2]")]
        public IWebElement editIcon;

        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]")]
        public IWebElement deleteIcon;
         
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Ace English Grammar')]")]
        public IWebElement checkTitle;

        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Conversational English')]")]
        public IWebElement editedTitle;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[3]/button[2]")]
        public IWebElement alertYes;

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]
        public IWebElement deleteConfirm;

        [FindsBy(How = How.XPath, Using = "//h3[contains(text(),'You do not have any service listings!')]")]
        public IWebElement deletedTitle;


        //public void ViewSkills(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    PageFactory.InitElements(driver, this);
        //    viewIcon.Click();
        //    Thread.Sleep(1000);
        //    Assert.That(checkTitle.Text == "Ace English Grammar", "Expected title and Actual title do no match");
        //}

        public void NagivateToEdit(IWebDriver driver)
        {
            Thread.Sleep(2000);
            PageFactory.InitElements(driver, this);
            editIcon.Click();
            Thread.Sleep(2000);
        
        }

        //public void ViewEditedSkills(IWebDriver driver)
        //{
        //    Thread.Sleep(2000);
        //    PageFactory.InitElements(driver, this);
        //    viewIcon.Click();
        //    Thread.Sleep(1000);
        //    Assert.That(editedTitle.Text == "Conversational English", "Expected title and Actual title do no match");
        //}

        public void DeleteSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            PageFactory.InitElements(driver, this);
            deleteIcon.Click();
            deleteConfirm.Click();
            Thread.Sleep(2000);
            Assert.That(deletedTitle.Text == "You do not have any service listings!", "Record is not deleted");

        }

    }
}
