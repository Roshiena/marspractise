using AventStack.ExtentReports;
using NUnit.Framework;
using Onlylearning.Pages;
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
            try
            {
                test = extentreportobj.CreateTest("CreateSkills", "Testing Create Skills");
                profilePageObj.NavigateShareSkills(driver);
                skillsPageObj.CreateSkills(driver);
                ClickScreenshot.CreateSkillScreenShot(driver);
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
               ClickScreenshot.CreateSkillScreenShot(driver);
                test.Log(Status.Fail, "Test failed");
               Assert.Fail("Create Skills Test failed", ex.Message);
                throw;

            }
           
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
            try
            {
                test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
                profilePageObj.NavigateManageListings(driver);
                listingsPageObj.NagivateToEdit(driver);
                skillsPageObj.EditSkills(driver);
                ClickScreenshot.EditSkillScreenShot(driver);
                test.Log(Status.Info, "Skills edited successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshot.EditSkillScreenShot(driver);
                test.Log(Status.Fail, "Test passed");
                Assert.Fail("Edit Skills Test failed", ex.Message);
                throw;

            }
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
            try
            {
                test = extentreportobj.CreateTest("DeleteSkills", "Testing Delete Skills");
                profilePageObj.NavigateManageListings(driver);
                listingsPageObj.DeleteSkills(driver);
                ClickScreenshot.DeleteSkillScreenShot(driver);
                test.Log(Status.Info, "Skills deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)

            {
                ClickScreenshot.DeleteSkillScreenShot(driver);
                test.Log(Status.Fail, "Test failed");
                Assert.Fail("Delete Skills Test failed", ex.Message);
                throw;
            }
        }
            
    }
}
