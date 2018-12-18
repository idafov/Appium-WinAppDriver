using NUnit.Framework;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class NotepadPagePbjectsTests
    {
        private WindowsDriver<WindowsElement> _driver;
        private NotepadView _notepad;

        private string WinAppDriverUrl = "http://127.0.0.1:4723";
        private string NotepadAppId = "notepad.exe";

        [Test]
        public void TypeSmthAndAssert()
        {
            var appCapabilities = new DesiredCapabilities();
            appCapabilities.SetCapability("app", NotepadAppId);

            _driver = new WindowsDriver<WindowsElement>(new Uri(WinAppDriverUrl), appCapabilities);
            _driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(5));
            _driver.Manage().Window.Maximize();

            _notepad = new NotepadView(_driver);
            _notepad.TypeAndChangeFont();
            Assert.AreEqual("bla-bla-bla, Radinovo 2018", _driver.FindElementByClassName("Edit").Text);
        }
        [TearDown]
        public void TearDown()
        {
            if (_driver != null)

            {
                _driver.Close();
                try
                {
                    _driver.FindElementByName("Don't Save").Click(); ;
                }
                catch
                {
                    _driver.Quit();
                    _driver = null;
                }
            }
        }
    }
}
