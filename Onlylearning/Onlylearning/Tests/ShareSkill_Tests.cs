using NUnit.Framework;
using Onlylearning.Pages;
using Onlylearning.Utilities;
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
            
            profilePageObj.NavigateShareSkills(driver);
            skillsPageObj.CreateSkills(driver);
        }

        [Test, Order(2)]
        public void ViewSkillsTest()
        {
            
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.ViewSkills(driver);
           

        }

        [Test, Order(3)]

        public void EditSkillsTest()
        {
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.NagivateToEdit(driver);
            skillsPageObj.EditSkills(driver);
        }

        [Test, Order(4)]

        public void ViewEditedSkillTest()
        {
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.ViewEditedSkills(driver);

        }


        [Test, Order(5)]
        public void DeleteSkillsTest()
        {
            profilePageObj.NavigateManageListings(driver);
            listingsPageObj.DeleteSkills(driver);
        }
            
    }
}
