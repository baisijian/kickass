﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AcceptanceTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("sitemap xml test")]
    public partial class SitemapXmlTestFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "sitemap.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "sitemap xml test", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("sitemap that contains XMLs should display correctly")]
        [NUnit.Framework.TestCaseAttribute("index-main", "www.casa.it", "sitemap.aspx", null)]
        public virtual void SitemapThatContainsXMLsShouldDisplayCorrectly(string id, string site_Root, string site_Url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("sitemap that contains XMLs should display correctly", exampleTags);
#line 3
this.ScenarioSetup(scenarioInfo);
#line 4
 testRunner.Given(string.Format("I\'m on the \"{0}\" page of \"{1}\"", site_Url, site_Root), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.Then(string.Format("The root element in xml of \"{0}\" \'s attribute should be correct in XML that conta" +
                        "ins XMLs", site_Root), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 6
 testRunner.And(string.Format("The XML structure of \"{0}\" should be right in XML that contains XMLs", site_Root), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "URL"});
            table1.AddRow(new string[] {
                        "/sitemap_details.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_vendita_residenziale.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_vendita_commerciale.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_vendita_vacanze.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_affitti_residenziale.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_affitti_commerciale.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_results_affitti_vacanze.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_agency_folders.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_find_agents_urls.xml"});
            table1.AddRow(new string[] {
                        "/sitemap_legacy_urls.xml"});
#line 7
 testRunner.Then(string.Format("On \"{0}\" the XML should contains:", id), ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
