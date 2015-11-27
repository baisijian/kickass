using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace AcceptanceTest.step_utility
{
    public class sitemap_feature_utility
    {
        public string getRootURL(string flag) {
            return flag.Equals("www.casa.it") ? CommonUtility.main_site_url : CommonUtility.m_site_url;
        }

        public void AssertSitemapsStructureForXmlContainsXMLs(string siteRoot, ReadOnlyCollection<IWebElement> sitemaps)
        {
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("loc")).Count, 1);
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("lastmod")).Count, 1);
            Assert.IsTrue(sitemaps[0].FindElement(By.TagName("loc")).Text.Contains(siteRoot));


            //Assert.AreEqual(sitemaps[1].FindElements(By.TagName("lastmod")).Count, 1);
            //Assert.IsTrue(sitemaps[1].FindElement(By.TagName("loc")).Text.Contains(siteRoot));


            //aaaa
            //Assert.AreEqual(sitemaps[1].FindElements(By.TagName("loc")).Count, 6);
        }

        public void AssertXmlRootAndNameSpaceCorrectlyForXmlContainsXmls(string siteRoot, ReadOnlyCollection<IWebElement> root_elements, string nameSpace, string nameSpaceUrl)
        {
            Assert.AreEqual(root_elements.Count, 1);

            string xml_namespace = root_elements[0].GetAttribute(nameSpace);
            Assert.IsNotNull(xml_namespace);
            Assert.AreEqual(xml_namespace, nameSpaceUrl);
        }

        public void AssertSitemapsStructureForXmlContainsUrls(string siteRoot, ReadOnlyCollection<IWebElement> sitemaps)
        {
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("loc")).Count, 1);
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("lastmod")).Count, 1);
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("changefreq")).Count, 1);
            Assert.AreEqual(sitemaps[0].FindElements(By.TagName("priority")).Count, 1);
            Assert.IsTrue(sitemaps[0].FindElement(By.TagName("loc")).Text.Contains(siteRoot));

            Assert.AreEqual(sitemaps[1].FindElements(By.TagName("loc")).Count, 1);
            Assert.AreEqual(sitemaps[1].FindElements(By.TagName("lastmod")).Count, 1);
            Assert.AreEqual(sitemaps[1].FindElements(By.TagName("changefreq")).Count, 1);
            Assert.AreEqual(sitemaps[1].FindElements(By.TagName("priority")).Count, 1);
            Assert.IsTrue(sitemaps[1].FindElement(By.TagName("loc")).Text.Contains(siteRoot));

            if (siteRoot == "m.casa.it")
            {
                Assert.AreEqual(sitemaps[0].FindElements(By.TagName("mobile:mobile")).Count, 1);
                Assert.AreEqual(sitemaps[1].FindElements(By.TagName("mobile:mobile")).Count, 1);
            }
        }

        public void AssertXmlRootAndNameSpaceCorrectlyForXmlContainsUrls(string siteRoot, ReadOnlyCollection<IWebElement> root_elements, string nameSpace, string nameSpaceUrl)
        {
            Assert.AreEqual(root_elements.Count, 1);

            string xml_namespace = root_elements[0].GetAttribute(nameSpace);
            if (siteRoot == "m.casa.it") {
                Assert.AreEqual(root_elements[0].GetAttribute("xmlns"), "http://www.sitemaps.org/schemas/sitemap/0.9");
            }

            Assert.IsNotNull(xml_namespace);
            Assert.AreEqual(xml_namespace, nameSpaceUrl);
        }
    }
}
