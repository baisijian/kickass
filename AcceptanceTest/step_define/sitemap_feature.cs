using AcceptanceTest.step_utility;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace AcceptanceTest.step_define
{
    [Binding]
    public sealed class sitemap_feature
    {

        private IWebDriver driver;
        private StringBuilder verificationErrors;
        sitemap_feature_utility siteMapUtility = null;
        [BeforeScenario]
        public void BeforeScenarioSetup()
        {
            driver = new FirefoxDriver();
            verificationErrors = new StringBuilder();
            siteMapUtility = new sitemap_feature_utility();
        }

        [AfterScenario]
        public void AfterScenarioSetup()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

        [Given(@"I'm on the ""(.*)"" page of ""(.*)""")]
        public void GivenIMOnThePage(string siteURL, string siteRoot)
        {
            string goToURL = Path.Combine(siteMapUtility.getRootURL(siteRoot), siteURL);
            driver.Navigate().GoToUrl(goToURL);
        }

        [Then(@"The root element in xml of ""(.*)"" 's attribute should be correct in XML that contains XMLs")]
        public void ThenTheRootElementInXmlOfSAttributeValueShouldBeInXMLThatContainsXMLs(string siteRoot)
        {
            string nameSpace = "xmlns";
            string nameSpaceUrl = "http://www.sitemaps.org/schemas/sitemap/0.9";
            var root_elements = driver.FindElements(By.TagName("sitemapindex"));
            siteMapUtility.AssertXmlRootAndNameSpaceCorrectlyForXmlContainsXmls(siteRoot, root_elements, nameSpace, nameSpaceUrl);
        }


        [Then(@"The XML structure of ""(.*)"" should be right in XML that contains XMLs")]
        public void ThenTheXMLStructureOfShouldBeRight(string siteRoot)
        {
            var sitemaps = driver.FindElements(By.TagName("sitemap"));
            siteMapUtility.AssertSitemapsStructureForXmlContainsXMLs(siteRoot, sitemaps);
        }

        [Then(@"On ""(.*)"" the XML should contains:")]
        public void ThenTheXMLShouldContains(string Id, Table table)
        {
            if (Id.Contains("index"))
            {
                foreach (var row in table.Rows)
                {
                    Assert.IsTrue(driver.PageSource.Contains(row["URL"].ToString()));
                }
            }
        }

        [Then(@"The root in xml of ""(.*)"" 's ""(.*)"" attribute value should be ""(.*)"" in XML that contains URLs""")]
        public void ThenTheRootInXmlOfSAttributeValueShouldBeInXMLThatContainsURLs(string siteRoot, string nameSpace, string nameSpaceUrl)
        {
            var root_elements = driver.FindElements(By.TagName("urlset"));
            siteMapUtility.AssertXmlRootAndNameSpaceCorrectlyForXmlContainsUrls(siteRoot, root_elements, nameSpace, nameSpaceUrl);
        }

        [Then(@"The XML structure of ""(.*)"" should be right in XML that contains URLs")]
        public void ThenTheXMLStructureOfShouldBeRightinXMLThatContainsURLs(string siteRoot)
        {
            var sitemaps = driver.FindElements(By.TagName("url"));
            siteMapUtility.AssertSitemapsStructureForXmlContainsUrls(siteRoot, sitemaps);
        }

    }
}
