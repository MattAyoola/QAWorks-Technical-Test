using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using QAWorks.Helper;
using QAWorks.Pages;

namespace QAWorks.Hooks
{
    [Binding]
    public sealed class Setup
    {
        private readonly Context _context;
        public Setup(Context context)
        {
            _context = context;
        }

  

        [BeforeScenario]
        public void BeforeScenario()
        {
            _context.LaunchBrowser();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _context.TearDownBrowser(); 
        }
    }
}
