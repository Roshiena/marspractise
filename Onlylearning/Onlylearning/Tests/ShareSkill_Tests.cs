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
        ManageListings ListingsPageObj = new ManageListings();


        [Test, Order(1)]
        public void CreateSkillTest()
        {
            skillsPageObj.CreateSkills(driver);
        }

        [Test, Order(2)]
        public void ViewSkillsTest()
        {
            
            profilePageObj.NavigateManageSkills(driver);
            ListingsPageObj.ViewSkills(driver);
           

        }

        [Test, Order(3)]

        public void EditSkillsTest()
        {
            profilePageObj.NavigateManageSkills(driver);
            ListingsPageObj.NagivateToEdit(driver);
            skillsPageObj.EditSkills(driver);
        }

        [Test, Order(4)]
        public void DeleteSkillsTest()
        {
            profilePageObj.NavigateManageSkills(driver);
            ListingsPageObj.DeleteSkills(driver);
        }
            
    }
}
