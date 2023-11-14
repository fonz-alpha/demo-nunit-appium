using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppiumDemo.Pages;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;

namespace AppiumDemo.Test
{
    [TestFixture]
    [Category("appium-demo")]
    public class SearchWikipediaReturnsResultsImplicit : NUnitTest
    {

        [Test]
        public void SearchWikipedia()
        {
            driver.FindElement(WikipediaMainPage.searchGlassIcon).Click();

            driver.FindElement(WikipediaMainPage.searchInput).SendKeys("TEST");

            ReadOnlyCollection<AndroidElement> resultsList = driver.FindElements(WikipediaMainPage.searchResultsList);
            Assert.True(resultsList.Count > 0);
        }
    }
}
