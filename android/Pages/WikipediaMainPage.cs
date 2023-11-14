using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;

namespace AppiumDemo.Pages
{
    public class WikipediaMainPage : NUnitTest
    {
        public static By searchGlassIcon = MobileBy.AccessibilityId("Search Wikipedia");

        public static By searchInput = By.Id("org.wikipedia.alpha:id/search_src_text");

        public static By searchResultsList = By.XPath("//android.widget.LinearLayout[@resource-id=\"org.wikipedia.alpha:id/page_list_item_container\"]");
    }
}
