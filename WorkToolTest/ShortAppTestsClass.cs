using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using SikuliSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;



namespace ShortAppToolTesting
{
    
    public class ShortAppTestsClass
    {       
        private WindowsDriver<WindowsElement> _driver;
        private ShortAppToolView _shortAppTool;
        private bool tryAgain = true;
        
        private string WinAppDriverUrl = "http://127.0.0.1:4723";
        private string ShortAppToolId = @"C:\Users\lhmdai1\Documents\ApplShort\ApplShortTestTool\runapp.bat";
        

        [SetUp]
        public void SetUp()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", ShortAppToolId);

            //Following code is necessary to avoid problems with apps opening
            //bool tryAgain = true;
            while (tryAgain)
            {
                try
                {                    
                    _driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl), appCapabilities);
                    Thread.Sleep(1500);
                    break;
                }
                catch (Exception)
                {
                   
                }

            }
                       
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
        }

        [Test]
        public void OpenToolAndClickOnMainTabs()
        {

            _shortAppTool = new ShortAppToolView(_driver);


            while (tryAgain)
            {
                try
                {
                    _shortAppTool.ClickTestNotesTab();
                    break;
                }
                catch (Exception)
                {
                   
                }

            }
            //_shortAppTool.TestNotesTabAssertion() check if Test notes tab is clicable and open
            _shortAppTool.TestNotesTabAssertion();

            //_shortAppTool.ClickTodLoggerTab() click on Tod Logger tab
            _shortAppTool.ClickTodLoggerTab();

            //_shortAppTool.EnsureTodLoggerTabIsClicableAndOpen() check if Tod Logger tab is clicable and open
            _shortAppTool.EnsureTodLoggerTabIsClicableAndOpen();

            //_shortAppTool.ClickTestLogEvaluationTab() check if Test Log Evaluation tab is clicable and open
            _shortAppTool.ClickTestLogEvaluationTab();

            // _shortAppTool.EnsureTestLogEvaluationTabIsClicableAndOpen() check if Test Log Evaluation tab is open
            _shortAppTool.EnsureTestLogEvaluationTabIsClicableAndOpen();

            // _shortAppTool.ClickTestRunTab() click on Test Run tab
            _shortAppTool.ClickTestRunTab();

            //_shortAppTool.EnsureTestRunTabIsClicableAndOpen() check if Test Run tab is clicable and open
            _shortAppTool.EnsureTestRunTabIsClicableAndOpen();
        }


        [Test]
        public void OpenToolAndClickOnSelectConFile()
        {
            _shortAppTool = new ShortAppToolView(_driver);
            while (tryAgain)
            {
                try
                {
                    _shortAppTool.ClickConFileTabOnly();
                                        
                    break;
                }
                catch (Exception)
                {
                   
                }

            }

            _shortAppTool.ConFileLocationWin();
           
        }

       
        [TearDown]
        public void TearDown()
        {
            //TODO
            
        }
    }
}
