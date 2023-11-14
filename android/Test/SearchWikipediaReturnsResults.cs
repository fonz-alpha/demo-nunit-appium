using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Support.UI;

namespace AppiumDemo.Test
{
    [TestFixture]
    [Category("appium-demo")]
    public class SearchWikipediaReturnsResults : NUnitTest
    {
        [Test]
        public void SearchWikipedia()
        {
            AndroidElement searchHourglassIcon = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(MobileBy.AccessibilityId("Search Wikipedia")));
            searchHourglassIcon.Click();

            AndroidElement searchInput = (AndroidElement)new WebDriverWait(driver, TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(By.Id("org.wikipedia.alpha:id/search_src_text")));
            searchInput.SendKeys("TEST");

            ReadOnlyCollection<AndroidElement> resultsList = driver.FindElements(By.XPath("//android.widget.LinearLayout[@resource-id=\"org.wikipedia.alpha:id/page_list_item_container\"]"));
            Assert.True(resultsList.Count > 0);
        }


    }
}
