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

namespace QAWorks
{
    [Binding]
    public class ContactUsSteps : ContactPage
    {
       

        [Given(@"I am on the QAWorks Site")]
        public void GivenIAmOnTheQAWorksSite()
        {
            LaunchBrowser("http://www.qaworks.com/");
            Assert.AreEqual("QAWorks Limited - Software Quality & Delivery Experts", PageTitle());
        }

        [When(@"I navigate to contact us section")]
        public void WhenINavigateToContactUsSection()
        {
            NavigateToContactSession();
        }

        [Then(@"I should be able to contact QAWorks with the following information")]
        public void ThenIShouldBeAbleToContactQAWorksWithTheFollowingInformation(Table table)
        {
            var contactUs = new ContactModel();
            var ContactUsFields = table.CreateInstance<ContactModel>();
            Name(ContactUsFields.Name);
            Email(ContactUsFields.Email);
            Subject(ContactUsFields.Subject);
            Message(ContactUsFields.Message);
            Send();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TearDownBrowser();
        }
    
    }
}
