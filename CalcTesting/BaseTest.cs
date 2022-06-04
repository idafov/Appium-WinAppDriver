using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinAppDriver_FirstTests
{
    public class BaseTest
    {
        protected WindowsDriver<WindowsElement> driver;

        private const string appiumServer = "http://127.0.0.1:4723/wd/hub";
        private AppiumOptions options;
        private const string AppPath = @"C:\Users\lhmdai1\Downloads\WindowsFormsApp.exe";

        [OneTimeSetUp]
        public void Setup()
        {
            this.options = new AppiumOptions();
            options.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Windows");
            options.AddAdditionalCapability(MobileCapabilityType.App, AppPath);

            driver = new WindowsDriver<WindowsElement>(new Uri(appiumServer), options);

        }

        [SetUp]
        public void SetUp()
        {
            ClearFields();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [OneTimeTearDown]
        public void ShutDown()
        {
            driver.CloseApp();
        }


        public WindowsElement firstField => driver.FindElementByAccessibilityId("textBoxFirstNum");
        public WindowsElement SecondField => driver.FindElementByAccessibilityId("textBoxSecondNum");
        public WindowsElement CalcButton => driver.FindElementByAccessibilityId("buttonCalc");
        public WindowsElement SumBox => driver.FindElementByAccessibilityId("textBoxSum");

        public void SumTwoPositiveNumbers(string a, string b)
        {
            firstField.SendKeys(a);
            SecondField.SendKeys(b);
        }

        public void SumTwoNegativeNumbers(string a, string b)
        {
            firstField.SendKeys(a);
            SecondField.SendKeys(b);
        }

        public string GetResult()
        {
            return SumBox.Text;
        }

        public void ClearFields()
        {
            firstField.Clear();
            SecondField.Clear();
        }

        private static Random random = new Random();
        public string RandomString(int length = 1)
        {
            const string chars = "!@#$%^&*()_+:?><";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void SumTwoPositiveNumbersStartingWithSpecialSymbol(string a, string b)
        {
            firstField.SendKeys(RandomString() + a);
            SecondField.SendKeys(RandomString() + b);
        }
    }
}
