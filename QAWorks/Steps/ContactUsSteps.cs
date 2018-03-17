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
using TechTalk.SpecFlow.Assist;
using QAWorks.Pages;
using QAWorks.Model;
using QAWorks.Helper;

namespace QAWorks.Steps
{
    [Binding]
    public class ContactUsSteps
    {
        private readonly ContactPage _contactPage;
        private readonly Context _context;
        public ContactUsSteps(ContactPage contactPage, Context context)
        {
            _contactPage = contactPage;
            _context = context;
        }

        [Given(@"I am on the QAWorks Site")]
        public void IAmOnTheQAWorksSite()
        {
            var pageTitle = "QAWorks Limited - Software Quality & Delivery Experts";
            Assert.AreEqual(pageTitle, _context.PageTitle(), "Not on the expected site");
        }

        [When(@"I navigate to contact us section")]
        public void INavigateToContactUsSection()
        {
            _contactPage.NavigateToContactSession();
        
        }

        [Then(@"I should be able to contact QAWorks with the following information")]
        public void IShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            var contactUs = new ContactModel();
            var ContactUsFields = table.CreateInstance<ContactModel>();
            _contactPage.Name(ContactUsFields.Name);
            _contactPage.Email(ContactUsFields.Email);
            _contactPage.Subject(ContactUsFields.Subject);
            _contactPage.Message(ContactUsFields.Message);
            _contactPage.Send();
        }
    
    }
}
