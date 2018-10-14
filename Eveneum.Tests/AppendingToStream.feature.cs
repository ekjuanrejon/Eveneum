﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Eveneum.Tests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Appending to Existing Stream")]
    public partial class AppendingToExistingStreamFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "AppendingToStream.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Appending to Existing Stream", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with no events")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithNoEvents(string partitioned, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with no events", null, exampleTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 4
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 5
 testRunner.And("an existing stream S with 0 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 6
 testRunner.When("I append 10 events to stream S in expected version 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 7
 testRunner.Then("the header version 10 with no metadata is persisted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 8
 testRunner.And("new events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with metadata and no events")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithMetadataAndNoEvents(string partitioned, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with metadata and no events", null, exampleTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 15
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 16
 testRunner.And("an existing stream S with metadata and 0 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.When("I append 10 events to stream S in expected version 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 18
 testRunner.Then("the header version 10 with metadata is persisted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 19
 testRunner.And("new events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with some events")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithSomeEvents(string partitioned, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with some events", null, exampleTags);
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
 testRunner.And("an existing stream S with 10 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.When("I append 5 events to stream S in expected version 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 29
 testRunner.Then("the header version 15 with no metadata is persisted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 30
 testRunner.And("new events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with metadata and some events")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithMetadataAndSomeEvents(string partitioned, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with metadata and some events", null, exampleTags);
#line 36
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 37
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.And("an existing stream S with metadata and 20 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I append 10 events to stream S in expected version 20", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.Then("the header version 30 with metadata is persisted", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 41
 testRunner.And("new events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with no events with non-matching expected version fails")]
        [NUnit.Framework.CategoryAttribute("ExpectException")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithNoEventsWithNon_MatchingExpectedVersionFails(string partitioned, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExpectException"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with no events with non-matching expected version fails", null, @__tags);
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 51
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 52
 testRunner.And("an existing stream S with 0 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("I append 10 events to stream S in expected version 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 54
 testRunner.Then("the action fails as expected version 6 doesn\'t match the current version 0 of str" +
                    "eam S", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 55
 testRunner.And("no events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with metadata and no events with non-matching expected versio" +
            "n fails")]
        [NUnit.Framework.CategoryAttribute("ExpectException")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithMetadataAndNoEventsWithNon_MatchingExpectedVersionFails(string partitioned, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExpectException"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with metadata and no events with non-matching expected versio" +
                    "n fails", null, @__tags);
#line 62
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 63
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
 testRunner.And("an existing stream S with metadata and 0 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
 testRunner.When("I append 10 events to stream S in expected version 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 66
 testRunner.Then("the action fails as expected version 6 doesn\'t match the current version 0 of str" +
                    "eam S", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 67
 testRunner.And("no events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with some events with non-matching expected version fails")]
        [NUnit.Framework.CategoryAttribute("ExpectException")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithSomeEventsWithNon_MatchingExpectedVersionFails(string partitioned, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExpectException"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with some events with non-matching expected version fails", null, @__tags);
#line 74
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 75
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 76
 testRunner.And("an existing stream S with 10 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.When("I append 5 events to stream S in expected version 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 78
 testRunner.Then("the action fails as expected version 6 doesn\'t match the current version 10 of st" +
                    "ream S", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 79
 testRunner.And("no events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Appending to stream with metadata and some events with non-matching expected vers" +
            "ion fails")]
        [NUnit.Framework.CategoryAttribute("ExpectException")]
        [NUnit.Framework.TestCaseAttribute("partitioned", null)]
        [NUnit.Framework.TestCaseAttribute("non-partitioned", null)]
        public virtual void AppendingToStreamWithMetadataAndSomeEventsWithNon_MatchingExpectedVersionFails(string partitioned, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ExpectException"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Appending to stream with metadata and some events with non-matching expected vers" +
                    "ion fails", null, @__tags);
#line 86
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 87
 testRunner.Given(string.Format("an event store backed by {0} collection", partitioned), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 88
 testRunner.And("an existing stream S with metadata and 20 events", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When("I append 10 events to stream S in expected version 6", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 90
 testRunner.Then("the action fails as expected version 6 doesn\'t match the current version 20 of st" +
                    "ream S", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 91
 testRunner.And("no events are appended", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
