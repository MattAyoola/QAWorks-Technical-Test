using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QAWorks
{
    public class ContactPage
    {
        public IWebDriver driver;

        public void LaunchBrowser(string baseUrl)
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(baseUrl);
        }

        public void TearDownBrowser()
        {
            Console.WriteLine(driver.Url);
            driver.Quit();
            driver.Dispose();
        }

        public string PageTitle()
        {
            return driver.Title;
        }

        public void NavigateToContactSession()
        {
           driver.FindElement(By.XPath("//*[@id='menu-item-18894']/a/span")).Click();
        }

        public void Name(string name)
        {
            driver.FindElement(By.XPath("//*[@id='qaworks-contact-us']/p[1]/label/span/input")).SendKeys(name);
        }
        public void Email(string email)
        {
            driver.FindElement(By.XPath("//*[@id='qaworks-contact-us']/p[2]/label/span/input")).SendKeys(email);
        }
        public void Subject(string subject)
        {
            driver.FindElement(By.XPath("//*[@id='qaworks-contact-us']/p[3]/label/span/input")).SendKeys(subject);
        }
        public void Message(string message)
        {
            driver.FindElement(By.XPath("//*[@id='qaworks-contact-us']/p[4]/label/span/textarea")).SendKeys(message);
        }
        public void Send()
        {
            driver.FindElement(By.Id("contact-us-send")).Click();
        }
    }
}
