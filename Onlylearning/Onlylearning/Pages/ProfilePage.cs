﻿using NUnit.Framework;
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
    public class ProfilePage : CommonDriver
    {




        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        public IWebElement shareSkillsButton;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        public IWebElement manageListings;

        public void NavigateShareSkills()
        {
            PageFactory.InitElements(driver, this);
            shareSkillsButton.Click();

        }

        public void NavigateManageListings()
        {
            PageFactory.InitElements(driver, this);
            manageListings.Click();
        }




    }
}