﻿using AventStack.ExtentReports.Reporter;
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
using System.Security.Cryptography.X509Certificates;

namespace Onlylearning.Utilities
{
    [SetUpFixture]
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
            string userName = LoginCredential.string1;




            var htmlreporter = new ExtentHtmlReporter(@"C:\Users\roshi\OneDrive\Documents\Marsrough\marspractise\Onlylearning\Onlylearning\ExtentReports");
            extentreportobj = new ExtentReports();
            extentreportobj.AttachReporter(htmlreporter);

            //Open chrome
            driver = new ChromeDriver();
            //Maximize the chrome window
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(LoginCredential.string3);

            
            

            if (userName == LoginCredential.string1)
            {
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginStep();
                
            }
            else
            {   
              
                SignupPage signupPageObj = new SignupPage();
                signupPageObj.SignUp();
            }


        }
        public static void Waits()
        {
            // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            extentreportobj.Flush();
            
            driver.Quit();
            
        }
    }
}
