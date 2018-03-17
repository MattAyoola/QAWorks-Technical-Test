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
using QAWorks.Hooks;
using QAWorks.Helper;

namespace QAWorks.Pages
{
    public class ContactPage
    {
        private readonly Context _context;
        public ContactPage(Context context)
        {
            _context = context;
        }
        By _contactSession = By.XPath("//*[@id='menu-item-18894']/a/span");
        By _name = By.XPath("//*[@id='qaworks-contact-us']/p[1]/label/span/input");
        By _email = By.XPath("//*[@id='qaworks-contact-us']/p[2]/label/span/input");
        By _subject = By.XPath("//*[@id='qaworks-contact-us']/p[3]/label/span/input");
        By _message = By.XPath("//*[@id='qaworks-contact-us']/p[4]/label/span/textarea");
        By _sendButton = By.Id("contact-us-send");

               
        public void NavigateToContactSession()
        {
            _context.driver.FindElement(_contactSession).Click();
        }

        public void Name(string name)
        {
            _context.driver.FindElement(_name).SendKeys(name);
        }
        public void Email(string email)
        {
            _context.driver.FindElement(_email).SendKeys(email);
        }
        public void Subject(string subject)
        {
            _context.driver.FindElement(_subject).SendKeys(subject);
        }
        public void Message(string message)
        {
            _context.driver.FindElement(_message).SendKeys(message);
        }
        public void Send()
        {
            _context.driver.FindElement(_sendButton).Click();
        }
    }
}
