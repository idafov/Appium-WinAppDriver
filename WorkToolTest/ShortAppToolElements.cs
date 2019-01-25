using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortAppToolTesting
{
    public partial class ShortAppToolView
    {

        public WindowsElement SelectLogFile => _driver.FindElementByAccessibilityId("56");
    }



}
