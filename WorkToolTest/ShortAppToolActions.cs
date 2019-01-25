using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using SikuliSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShortAppToolTesting
{
    public partial class ShortAppToolView
    {
        private readonly WindowsDriver<WindowsElement> _driver;
        public ShortAppToolView(WindowsDriver<WindowsElement> driver) => _driver = driver;


        //TC #1
        //Following test click on the "Test notes tab" and assert if it is really open on the app UI
        //----------------------------------------------------------------------------------------------
        public void ClickTestNotesTab()
        {
            using (var session = Sikuli.CreateSession())
            {

                var testNotesTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\test.PNG", 0.9f);

                session.Click(testNotesTab);

            }
        }

        public void TestNotesTabAssertion()
        {
            using (var session = Sikuli.CreateSession())
            {
                var testNotesTabAssert = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\testNotesTabAssertion.PNG", 0.9f);
                Assert.That(session.Exists(testNotesTabAssert), Is.True);
            }
        }
        //End TC #1
        //----------------------------------------------------------------------------------------------



        //TC #2
        //Following test click on the "Select con file" tab and assert if the tool open new window to specify path to con file
        //----------------------------------------------------------------------------------------------
        public void ClickConFileTabOnly()
        {
            using (var session = Sikuli.CreateSession())
            {

                var conFileTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\ConFileTab.PNG", 0.9f);
                session.Click(conFileTab);

            }
        }

        public void ConFileLocationWin()
        {
            using (var session = Sikuli.CreateSession())
            {

                var conFileTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\openConPathWin.PNG", 0.9f);
                Assert.That(session.Exists(conFileTab), Is.True);
            }

        }
        //End TC #2
        //----------------------------------------------------------------------------------------------



        //TC #3
        //Following test click on the "Tod Logger" tab and assert if the tool open new window
        //----------------------------------------------------------------------------------------------
        public void ClickTodLoggerTab()
        {
            using (var session = Sikuli.CreateSession())
            {
                var todLoggerTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\todLoggerImage.PNG", 0.9f);
                session.Click(todLoggerTab);
            }

        }


        public void EnsureTodLoggerTabIsClicableAndOpen()
        {
            using (var session = Sikuli.CreateSession())
            {

                var loggerTabAssertion = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\todLoggerTabAssertion.PNG", 0.9f);
                Assert.That(session.Exists(loggerTabAssertion), Is.True);
            }

        }
        //End TC #3
        //----------------------------------------------------------------------------------------------

        

        //TC #3
        //Following test click on the "Test Log Evaliation" tab and assert if the tool open new window
        //----------------------------------------------------------------------------------------------
        public void ClickTestLogEvaluationTab()
        {
            using (var session = Sikuli.CreateSession())
            {
                var testLogEvaTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\TestLogEvaluationTab.PNG", 0.9f);
                session.Click(testLogEvaTab);
            }

        }

        public void EnsureTestLogEvaluationTabIsClicableAndOpen()
        {
            using (var session = Sikuli.CreateSession())
            {

                var evaluationTabAssertion = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\testLogEvaAssertion.PNG", 0.9f);
                Assert.That(session.Exists(evaluationTabAssertion), Is.True);
                
            }

        }
        //End TC #3
        //----------------------------------------------------------------------------------------------


        //TC #4
        //Following test click on the "Test Run" tab and assert if the tool open new window
        //----------------------------------------------------------------------------------------------
        public void ClickTestRunTab()
        {
            using (var session = Sikuli.CreateSession())
            {
                var testRunTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\testRunTab.PNG", 0.9f);
                session.Click(testRunTab);
            }

        }

        public void EnsureTestRunTabIsClicableAndOpen()
        {
            using (var session = Sikuli.CreateSession())
            {

                var testRunTabAssertion = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\testRunTabAssertion.PNG", 0.9f);
                Assert.That(session.Exists(testRunTabAssertion), Is.True);
            }

        }
        //End TC #4
        //----------------------------------------------------------------------------------------------

        public void ScreenshotOnFail()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)

            {
                var screenshot = ((ITakesScreenshot)_driver).GetScreenshot();
                screenshot.SaveAsFile(Path.GetFullPath("../../Screenshots/") + TestContext.CurrentContext.Test.Name + ".png", System.Drawing.Imaging.ImageFormat.Png);

            }
        }


        public void ClickLogFileTabOnly()
        {
            using (var session = Sikuli.CreateSession())
            {

                var logFileTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\selectLogFileTab.PNG", 0.9f);
                session.Click(logFileTab);
            }
        }

        public void LogFileLocationWin()
        {
            using (var session = Sikuli.CreateSession())
            {

                var logFileTab = Patterns.FromFile(@"C:\Users\lhmdai1\Documents\selectLogFileAssertion.PNG", 0.9f);
                Assert.That(session.Exists(logFileTab), Is.True);
            }

        }        
    }
}
