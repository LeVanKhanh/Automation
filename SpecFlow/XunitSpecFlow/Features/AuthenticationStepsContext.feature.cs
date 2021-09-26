﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace XunitSpecFlow.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class LoginAdminPageStepsContextFeature : object, Xunit.IClassFixture<LoginAdminPageStepsContextFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "AuthenticationStepsContext.feature"
#line hidden
        
        public LoginAdminPageStepsContextFeature(LoginAdminPageStepsContextFeature.FixtureData fixtureData, XunitSpecFlow_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Login Admin Page(StepsContext)", "\tWho: Application administrator\r\n\tWhat: Login to admin page\r\n\tWhy: To mange appli" +
                    "cation settings\r\n\t“As a [persona], I [want to], [so that].”\r\n\tAs a application a" +
                    "dministrator, I want to login to admin page, so that I can manage the applicatio" +
                    "n settings", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
#line hidden
#line 9
 testRunner.Given("I access the authentication page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Authentication successful")]
        [Xunit.TraitAttribute("FeatureTitle", "Login Admin Page(StepsContext)")]
        [Xunit.TraitAttribute("Description", "Authentication successful")]
        [Xunit.TraitAttribute("Category", "AuthenticationSuccessful")]
        [Xunit.InlineDataAttribute("admin", "admin", new string[0])]
        [Xunit.InlineDataAttribute("administrator", "administrator", new string[0])]
        [Xunit.InlineDataAttribute("superadmin", "superadmin", new string[0])]
        [Xunit.InlineDataAttribute("superadministrator", "superadministrator", new string[0])]
        public virtual void AuthenticationSuccessful(string username, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AuthenticationSuccessful"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Authentication successful", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 12
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 13
 testRunner.And(string.Format("StepsContext the username is {0}", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("StepsContext the password is {0}", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.When("StepsContext trigger login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("StepsContext the IsAuthenticated should be true", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableTheoryAttribute(DisplayName="Authentication failed")]
        [Xunit.TraitAttribute("FeatureTitle", "Login Admin Page(StepsContext)")]
        [Xunit.TraitAttribute("Description", "Authentication failed")]
        [Xunit.TraitAttribute("Category", "AuthenticationFailed")]
        [Xunit.InlineDataAttribute("ToNullString", "admin", "The username and password are requied!", new string[0])]
        [Xunit.InlineDataAttribute("admin", "ToNullString", "The username and password are requied!", new string[0])]
        [Xunit.InlineDataAttribute("", "admin", "The username and password are requied!", new string[0])]
        [Xunit.InlineDataAttribute("admin", "", "The username and password are requied!", new string[0])]
        [Xunit.InlineDataAttribute("admim", "admin", "The username or password is incorrect!", new string[0])]
        [Xunit.InlineDataAttribute("admin", "admim", "The username or password is incorrect!", new string[0])]
        public virtual void AuthenticationFailed(string username, string password, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "AuthenticationFailed"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("username", username);
            argumentsOfScenario.Add("password", password);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Authentication failed", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
this.FeatureBackground();
#line hidden
#line 27
 testRunner.And(string.Format("StepsContext the username is {0}", username), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("StepsContext the password is {0}", password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("StepsContext trigger login", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then(string.Format("StepsContext the Message should be {0}", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                LoginAdminPageStepsContextFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                LoginAdminPageStepsContextFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
