using Onlylearning.Input;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.PageObjects;
using Onlylearning.Utilities;
using ExcelDataReader;
using OpenQA.Selenium.Support.UI;
using MongoDB.Driver;
using System.Diagnostics;
using System.Reflection.Metadata;
using NUnit.Framework;
using System.Xml.Linq;
using System.IO;

namespace Onlylearning.Pages
{
    public class ShareSkillsPage 
    {
      
        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
        public IWebElement titleTextBox;

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement descriptionTextbox;

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement categoryDropdown;

        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement subCategory;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        public IWebElement tagName;

        //Select the Service type - hourly service 
           
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement hourlyServiceType;


        //Select One Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement oneOffServiceType;

        //Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement onSiteLocation;

        //Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement onlineLocation;

        [FindsBy(How = How.Name, Using = "startDate")]
        public IWebElement startDate;

        [FindsBy(How = How.Name, Using = "endDate")]
        public IWebElement endDate;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[2]/div[1]")]
        public IWebElement daysAvail; 

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]")]
        public IWebElement selectWednesday;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]")]
        public IWebElement startTime;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]")]
        public IWebElement endTime;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]")]
        public IWebElement skillsExchange;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[2]/div[1]/input[1]")]
        public IWebElement selectCredit;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[1]/div[1]/input[1]")]
        public  IWebElement creditAmount;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")] 
        public IWebElement skillExchange;


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement workSample;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]")]
        public IWebElement selectActive;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1")]
        public IWebElement selectHidden;

        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        public IWebElement saveButton;




        public void CreateSkills(IWebDriver driver)
        {
            Thread.Sleep(2000);
            PageFactory.InitElements(driver, this);
           
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);
            

            //Identify the description text box and add the description
            descriptionTextbox.Click();
            string description = ExcelReader.ReadData(1, "Description");
            descriptionTextbox.SendKeys(description);

            categoryDropdown.Click();
            SelectElement selectCategory = new SelectElement(categoryDropdown);
            selectCategory.SelectByText(ExcelReader.ReadData(1, "Category"));

            subCategory.Click();
            SelectElement selectSubcategory = new SelectElement(subCategory);
            selectSubcategory.SelectByText(ExcelReader.ReadData(1, "SubCategory"));

            string tag = ExcelReader.ReadData(1, "Tags");
            tagName.SendKeys(tag);
            tagName.SendKeys(Keys.Enter);

            string serviceType = ExcelReader.ReadData(1, "ServiceType");
            if (serviceType.Equals("Hourly basis service"))
            {
                hourlyServiceType.Click();
            }
            else if (serviceType.Equals("One-off service"))
            {
                oneOffServiceType.Click();
            }

            
            string locationType = ((ExcelReader.ReadData(1, "LocationType")));
            if (locationType.Equals("On-site"))
            {
                onSiteLocation.Click();
            }
            else if (locationType.Equals("Online"))
            {
                onlineLocation.Click();
            }

            string startDateOn = ExcelReader.ReadData(1, "Start Date");
            startDate.SendKeys(startDateOn);

            string endDateOn = ExcelReader.ReadData(1, "End Date");
            endDate.SendKeys(endDateOn);

            selectWednesday.Click();

            string startTimeOn = ExcelReader.ReadData(1, "Start Time");
            startTime.SendKeys(startTimeOn);

            string endTimeOn = ExcelReader.ReadData(1, "End Time");
            endTime.SendKeys(endTimeOn);


            skillExchange.Click();
            string skillExchangeTag = ExcelReader.ReadData(1, "SkillsExchange");

            skillExchange.SendKeys(skillExchangeTag);
            skillExchange.SendKeys(Keys.Enter);

            workSample.Click();
            Thread.Sleep(2000);
            using (Process exeProcess = Process.Start(@"C:\Users\roshi\OneDrive\Documents\WorkSample.exe"))
            {
                exeProcess.WaitForExit();
            }

            selectActive.Click();
            Thread.Sleep(2000);

            saveButton.Click();
            Thread.Sleep(5000);


            IWebElement viewCreatedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewCreatedSkills.Click();
            Thread.Sleep(5000);
            IWebElement checkCreatedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Ace English Grammar')]"));
            Assert.That(checkCreatedTitle.Text == "Ace English Grammar", "Expected Title and Edited Title do not match");

        }

        
            

        public void EditSkills(IWebDriver driver)
        {
           
            PageFactory.InitElements(driver, this);
            Thread.Sleep(3000);
            titleTextBox.Clear();
            string editedTitle1 = ExcelReader.ReadData(2, "Title");
            titleTextBox.SendKeys(editedTitle1);

            descriptionTextbox.Clear();
            string editedDescription1 = ExcelReader.ReadData(2, "Description");
            descriptionTextbox.SendKeys(editedDescription1);

            string editedTag2 = ExcelReader.ReadData(1, "Tags");
            tagName.SendKeys(editedTag2);
            tagName.SendKeys(Keys.Enter);

            
 

            startDate.SendKeys(Input.ExcelReader.ReadData(2, "Start Date"));
            startDate.Click();
            endDate.SendKeys(Input.ExcelReader.ReadData(2, "End Date"));
            endDate.Click();

            for (int i = 2; i < 9; i++)
            {


                for (int j = 2; j < 9; j++)
                {
                    IWebElement startTime = CommonDriver.driver.FindElement(By.XPath("//div[" + i + "]/div[2]/input"));
                    
                    IWebElement endTime = CommonDriver.driver.FindElement(By.XPath("//div[" + j + "]/div[3]/input"));
                   
                    if (i == 2 && j == 2)
                    {
                        CommonDriver.driver.FindElement(By.XPath("//div[contains(@class,'twelve wide column')]//div[2]//div[1]//div[1]//input[1]")).Click();
                        startTime.SendKeys("0230PM");
                        startTime.SendKeys(Keys.Tab);
                        endTime.SendKeys("0630PM");
                    }
                    if (i == 3 && j == 3)
                    {
                        CommonDriver.driver.FindElement(By.XPath("//div[3]//div[1]//div[1]//input[1]")).Click();
                        startTime.SendKeys("0930AM");
                        endTime.SendKeys("0630PM");
                    }

                }
            }


            //string editedStartTime = ExcelReader.ReadData(2, "Start Time");
            //startTime.SendKeys(editedStartTime);

            //string editedendTime = ExcelReader.ReadData(2, "End Time");
            //endTime.SendKeys(editedendTime);

            selectCredit.Click();
            string creditAmt = ExcelReader.ReadData(2, "Credit Amount");
            creditAmount.SendKeys(creditAmt);

            saveButton.Click();
            
            Thread.Sleep(5000);
            IWebElement viewEditedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewEditedSkills.Click();
            Thread.Sleep(5000);
            IWebElement checkEditedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Conversational English')]"));
            Assert.That(checkEditedTitle.Text == "Conversational English", "Expected Title and Edited Title do not match");
        }
    }
}