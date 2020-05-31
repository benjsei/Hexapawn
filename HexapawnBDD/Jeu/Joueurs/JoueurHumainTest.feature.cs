// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace HexapawnBDD.Jeu.Joueurs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Joueur Humain")]
    public partial class JoueurHumainFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JoueurHumainTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Joueur Humain", "\tEn tant que Joueur Humain\n\tJe veux sélectionner mon déplacement de manière manue" +
                    "lle\n\tAfin de faire avancer mes pions", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Deplacement choisi parmi 3 deplacements")]
        [NUnit.Framework.CategoryAttribute("JoueurHumain")]
        public virtual void DeplacementChoisiParmi3Deplacements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deplacement choisi parmi 3 deplacements", null, new string[] {
                        "JoueurHumain"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table1.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table1.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table1.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 9
 testRunner.Given("J\'ai ces deplacements disponibles", ((string)(null)), table1, "Given ");
#line 14
 testRunner.When("Je choisie un déplacement 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table2.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 15
 testRunner.Then("le déplacement choisi est", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deplacement choisi parmi 1 deplacement")]
        [NUnit.Framework.CategoryAttribute("JoueurHumain")]
        public virtual void DeplacementChoisiParmi1Deplacement()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deplacement choisi parmi 1 deplacement", null, new string[] {
                        "JoueurHumain"});
#line 20
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table3.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 21
 testRunner.Given("J\'ai ces deplacements disponibles", ((string)(null)), table3, "Given ");
#line 24
 testRunner.When("Je choisie un déplacement 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table4.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 25
 testRunner.Then("le déplacement choisi est", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deplacement choisi n\'est pas dans les choix possibles")]
        [NUnit.Framework.CategoryAttribute("JoueurHumain")]
        public virtual void DeplacementChoisiNestPasDansLesChoixPossibles()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deplacement choisi n\'est pas dans les choix possibles", null, new string[] {
                        "JoueurHumain"});
#line 30
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table5.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table5.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table5.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 31
 testRunner.Given("J\'ai ces deplacements disponibles", ((string)(null)), table5, "Given ");
#line 36
 testRunner.When("Je choisie un déplacement 4", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table6.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 37
 testRunner.Then("le déplacement choisi est", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Deplacement choisi parmi 0 deplacement")]
        [NUnit.Framework.CategoryAttribute("JoueurHumain")]
        public virtual void DeplacementChoisiParmi0Deplacement()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deplacement choisi parmi 0 deplacement", null, new string[] {
                        "JoueurHumain"});
#line 42
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
#line 43
 testRunner.Given("J\'ai ces deplacements disponibles", ((string)(null)), table7, "Given ");
#line 45
 testRunner.When("Je choisie un déplacement 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 46
 testRunner.Then("le déplacement choisi est vide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
