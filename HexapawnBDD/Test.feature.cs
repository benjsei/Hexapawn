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
namespace HexapawnBDD
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("En tant que joueur")]
    public partial class EnTantQueJoueurFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Test.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "En tant que joueur", "Je veux visualiser un plateau de Hexapawn\nAfin de pouvoir commencer une partie", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Plateau de départ")]
        public virtual void PlateauDeDepart()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Plateau de départ", null, ((string[])(null)));
#line 5
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 6
    testRunner.Given("Le joueur du haut est Thomas, et il joue les pions R", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
    testRunner.Given("Le joueur du bas est Paul, et il joue les pions V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
    testRunner.When("ils démarrent une nouvelle partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 9
    testRunner.Then("ils voient ce plateau RRR___VVV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Plateau de départ le joueur avance son premier pion")]
        public virtual void PlateauDeDepartLeJoueurAvanceSonPremierPion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Plateau de départ le joueur avance son premier pion", null, ((string[])(null)));
#line 11
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 12
    testRunner.Given("Le joueur du haut est Thomas, et il joue les pions R", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 13
    testRunner.Given("Le joueur du bas est Paul, et il joue les pions V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 14
    testRunner.Given("ils démarrent une nouvelle partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 15
    testRunner.When("Thomas bouge son pion de 1:1 à 2:1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 16
    testRunner.Then("ils voient ce plateau _RRR__VVV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Plateau de départ le joueur avance son deuxieme pion")]
        public virtual void PlateauDeDepartLeJoueurAvanceSonDeuxiemePion()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Plateau de départ le joueur avance son deuxieme pion", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
    testRunner.Given("Le joueur du haut est Thomas, et il joue les pions R", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
    testRunner.Given("Le joueur du bas est Paul, et il joue les pions V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
    testRunner.Given("ils démarrent une nouvelle partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
    testRunner.When("Thomas bouge son pion de 1:2 à 2:2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
    testRunner.Then("ils voient ce plateau R_R_R_VVV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Plateau de départ le joueur avance un pion inexistant")]
        public virtual void PlateauDeDepartLeJoueurAvanceUnPionInexistant()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Plateau de départ le joueur avance un pion inexistant", null, ((string[])(null)));
#line 25
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 26
    testRunner.Given("Le joueur du haut est Thomas, et il joue les pions R", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 27
    testRunner.Given("Le joueur du bas est Paul, et il joue les pions V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 28
    testRunner.Given("ils démarrent une nouvelle partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 29
    testRunner.When("Thomas bouge son pion de 2:2 à 2:3", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
    testRunner.Then("ils voient ce plateau RRR___VVV", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Lister les coups possibles de départ pour le joueur du Bas")]
        public virtual void ListerLesCoupsPossiblesDeDepartPourLeJoueurDuBas()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Lister les coups possibles de départ pour le joueur du Bas", null, ((string[])(null)));
#line 32
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 33
    testRunner.Given("Le joueur du haut est Thomas, et il joue les pions R", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
    testRunner.Given("Le joueur du bas est Paul, et il joue les pions V", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
    testRunner.Given("ils démarrent une nouvelle partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
    testRunner.When("Thomas bouge son pion de 1:2 à 2:2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
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
#line 37
    testRunner.Then("Paul peut bouger en", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
