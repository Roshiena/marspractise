using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Onlylearning.Utilities;

namespace Only.learning.Screenshots
{
    public class ClickScreenshot
    {
        public static void CreateSkillScreenShot(IWebDriver driver)
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\Marsrough\marspractise\Onlylearning\Onlylearning\CreateSkills" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);
            
        }

        public static void EditSkillScreenShot(IWebDriver driver)
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\Marsrough\marspractise\Onlylearning\Onlylearning\EditSkills" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);

        }

        public static void DeleteSkillScreenShot(IWebDriver driver)
        {

            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Users\roshi\OneDrive\Documents\Marsrough\marspractise\Onlylearning\Onlylearning\DeleteSkills" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);

        }


    }
}
