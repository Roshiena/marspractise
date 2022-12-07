using AventStack.ExtentReports;
using NUnit.Framework;
using Onlylearning.Pages;
using Onlylearning.Screenshots;
using Onlylearning.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Tests
{
    [TestFixture]

    
    public class ShareSkill_Tests : CommonDriver
    {
        ProfilePage profilePageObj = new ProfilePage();
        ShareSkillsPage skillsPageObj = new ShareSkillsPage();
        ListingsPage listingsPageObj = new ListingsPage();

       //[SetUp]

        [Test, Order(1)]
        public void CreateSkillTest()
        {
            test = extentreportobj.CreateTest("CreateSkills", "Testing Create Skills");
            profilePageObj.NavigateShareSkills(driver);
            skillsPageObj.CreateSkills(driver);
            ClickScreenshot.ScreenShot(driver);
            test.Log(Status.Info, "Skills created successfully");
            test.Log(Status.Pass, "Test passed");
           
        }

        //[Test, Order(2)]
        //public void ViewSkillsTest()
        //{
            
        //    profilePageObj.NavigateManageListings(driver);
        //    listingsPageObj.ViewSkills(driver);
           

        //}

        [Test, Order(2)]

        public void EditSkillsTest()
        {
            test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.NagivateToEdit(driver);
            skillsPageObj.EditSkills(driver);
            ClickScreenshot.ScreenShot(driver);
            test.Log(Status.Info, "Skills edited successfully");
            test.Log(Status.Pass, "Test passed");
        }

        //[Test, Order(4)]

        //public void ViewEditedSkillTest()
        //{
        //    profilePageObj.NavigateManageListings(driver);
        //    listingsPageObj.ViewEditedSkills(driver);

        //}


        [Test, Order(3)]
        public void DeleteSkillsTest()
        {
            test = extentreportobj.CreateTest("DeleteSkills", "Testing Delete Skills");
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.DeleteSkills(driver);
            ClickScreenshot.ScreenShot(driver);
            test.Log(Status.Info, "Skills deleted successfully");
            test.Log(Status.Pass, "Test passed");
        }
            
    }
}
