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
                profilePageObj.NavigateShareSkills();
                skillsPageObj.CreateSkills();
                ClickScreenshot.CreateSkillScreenShot();
                string createdTitle = skillsPageObj.CheckCreatedSkill();
                Assert.That(createdTitle == "Ace English Grammar", "Expected Title and Edited Title do not match");
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
               ClickScreenshot.CreateSkillScreenShot();
               test.Log(Status.Fail, "Test failed");
               throw;

            }
           
        }

    

        [Test, Order(2)]

        public void EditSkillsTest()
        {
            try
            {
                test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
                profilePageObj.NavigateManageListings();
                listingsPageObj.NagivateToEdit();
                skillsPageObj.EditSkills();
                ClickScreenshot.EditSkillScreenShot();
                string editedTitle = skillsPageObj.CheckEditedSkills();
                Assert.That(editedTitle == "Conversational English", "Expected Title and Edited Title do not match");
                test.Log(Status.Info, "Skills edited successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshot.EditSkillScreenShot();
                test.Log(Status.Fail, "Test passed");
                throw;

            }
        }



        [Test, Order(3)]
        public void DeleteSkillsTest()
        {
            try
            {
                test = extentreportobj.CreateTest("DeleteSkills", "Testing Delete Skills");
                profilePageObj.NavigateManageListings();
                listingsPageObj.DeleteSkills();
                ClickScreenshot.DeleteSkillScreenShot();
                string deletedTitle = listingsPageObj.CheckDeletedSkill();
                Assert.That(deletedTitle == "You do not have any service listings!", "Record is not deleted");
                test.Log(Status.Info, "Skills deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)

            {
                ClickScreenshot.DeleteSkillScreenShot();
                test.Log(Status.Fail, "Test failed");
                
                throw;
            }
        }
            
    }
}
