using NUnit.Framework;
using Onlylearning.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Pages
{
    public class ProfilePage
    {




        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        public IWebElement shareSkillsButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        public IWebElement manageListings;

        public void NavigateShareSkills(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            shareSkillsButton.Click();

        }

        public void NavigateManageListings(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            manageListings.Click();
        }




    }
}