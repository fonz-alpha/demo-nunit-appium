using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumDemo.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Collections.ObjectModel;

namespace AppiumDemo.Test
{
    [TestFixture]
    [Category("appium-demo")]
    public class SearchWikipediaReturnsResultsExplicit : NUnitTest
    {
        [Test]
        public void SearchWikipedia()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(WikipediaMainPage.searchGlassIcon)).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(WikipediaMainPage.searchInput)).SendKeys("TEST");

            ReadOnlyCollection<AndroidElement> resultsList = driver.FindElements(WikipediaMainPage.searchResultsList);
            Assert.True(resultsList.Count > 0);
        }
    }
}
