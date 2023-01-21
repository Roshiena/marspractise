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
    public class ListingsPage : CommonDriver
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


      

        public void NagivateToEdit()
        {
            Waits();
            PageFactory.InitElements(driver, this);
            editIcon.Click();
            
        
        }

      
        public void DeleteSkills()
        {
            Waits();
            PageFactory.InitElements(driver, this);
            deleteIcon.Click();
            deleteConfirm.Click();
            
        }

        public string CheckDeletedSkill()
        {
            return deletedTitle.Text;
        }

    }
}
