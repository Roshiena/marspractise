using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using NUnit.Framework;
using Onlylearning.Input;
using Onlylearning.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Onlylearning.Utilities
{
    public class CommonDriver
    {
        
        //ExtentTest test;
        //ExtentHtmlReporter htmlreporter;
        public static IWebDriver driver;
        public static ExtentReports extentreportobj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;
        public static FileStream stream;

        [OneTimeSetUp]

        public void LoginFunction()
        {

            string fileName = @"C:\Users\roshi\OneDrive\Documents\SkillParticulars.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.ReadDataTable(stream, "SkillsProfile");

            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\roshi\OneDrive\Documents\Marsrough\marspractise\Onlylearning\Onlylearning\ExtentReports");
            extentreportobj = new ExtentReports();
            extentreportobj.AttachReporter(htmlreporter);

            //Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();

            //Login page object initialisation
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginStep(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            extentreportobj.Flush();
           // driver.Quit();
        }
    }
}
