using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace QAWorks.Helper
{
   public class Context
    {
        public IWebDriver driver;
        //string baseUrl = "http://www.qaworks.com/"; (store url in app.config)
        public void LaunchBrowser(string baseUrl = "http://www.qaworks.com/")
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void TearDownBrowser()
        {
            driver.Quit();
            driver.Dispose();
        }

        public string PageTitle()
        {
            return driver.Title;
        }
    }
}
