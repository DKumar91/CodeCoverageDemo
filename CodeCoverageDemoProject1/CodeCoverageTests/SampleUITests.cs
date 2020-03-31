using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CodeCoverageTests
{
    [TestClass]
    public class SampleUITests
    {
        public static IWebDriver driver = new ChromeDriver(@"C:\Users\dinesh.kumar\Documents\codecoverage\CodeCoverageDemoProject1");
        public static void openbrowser()
        {
            driver.Navigate().GoToUrl("http:\\localhost");
        }

        public static void enter_input(string fieldId, string value)
        {
            driver.FindElement(By.Id(fieldId)).SendKeys(value);
        }

        public static void click_findlargest_button()
        {
            driver.FindElement(By.Id("FeaturedContent_Button1")).Click();
        }

        public static void assertvaluedisplayed(string expectedvalue)
        {
            string actualtext = driver.FindElement(By.Id("FeaturedContent_Label1")).GetAttribute("innerHTML");
            Assert.AreEqual(actualtext, expectedvalue);

        }

        [TestMethod()]
        public void testcase1()
        {
            openbrowser();
            enter_input("FeaturedContent_TextBox1", "5");
            enter_input("FeaturedContent_TextBox2", "55");
            enter_input("FeaturedContent_TextBox3", "77");
            enter_input("FeaturedContent_TextBox4", "99");
            enter_input("FeaturedContent_TextBox5", "1000");
            click_findlargest_button();
            assertvaluedisplayed("1000");
            driver.Close();

        }

    }
}
