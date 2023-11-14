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

namespace AppiumDemo.Old
{
    [TestFixture]
    [Category("sample-test")]
    internal class SearchFindResults : NUnitTest
    {

        [Test]
        public void searchWikepediaReturnsResults()
        {

            wait.Until(ExpectedConditions.ElementToBeClickable(WikipediaMainPage.searchGlassIcon)).Click();

            wait.Until(ExpectedConditions.ElementToBeClickable(WikipediaMainPage.searchWikipediaInput)).SendKeys("TEST");

            ReadOnlyCollection<AndroidElement> _searchResultsList = driver.FindElements(WikipediaMainPage.searchResultsList);
            Assert.True(_searchResultsList.Count > 0);
        }
    }
}
