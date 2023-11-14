using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.Old
{
    [TestFixture]
    [Category("sample-test")]
    internal class SearchFindResultsClean : NUnitTest
    {
        [Test]
        public void searchWikepediaReturnsResultsClean()
        {
            driver.FindElement(WikipediaMainPage.searchGlassIcon).Click();

            driver.FindElement(WikipediaMainPage.searchWikipediaInput).SendKeys("TEST");

            ReadOnlyCollection<AndroidElement> _searchResultsList = driver.FindElements(WikipediaMainPage.searchResultsList);
            Assert.True(_searchResultsList.Count > 0);
        }
    }
}
