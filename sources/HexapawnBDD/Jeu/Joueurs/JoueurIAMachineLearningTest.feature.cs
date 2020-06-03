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
    [NUnit.Framework.DescriptionAttribute("Joueur IA Machine Learning")]
    public partial class JoueurIAMachineLearningFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "JoueurIAMachineLearningTest.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Joueur IA Machine Learning", "\tEn tant que Joueur IA Machine Learning\n\tJe veux sélectionner mon déplacement de " +
                    "manière optimisée\n\tAfin de faire avancer mes pions", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Déplacement choisi parmi 3 déplacements")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void DeplacementChoisiParmi3Deplacements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Déplacement choisi parmi 3 déplacements", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 8
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 9
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
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
#line 10
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table1, "And ");
#line 15
 testRunner.And("l\'index tiré aléatoirement est 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table2.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 17
 testRunner.Then("le déplacement choisi est", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Déplacement choisi parmi 4 déplacements")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void DeplacementChoisiParmi4Deplacements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Déplacement choisi parmi 4 déplacements", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 22
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 23
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table3.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table3.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table3.AddRow(new string[] {
                        "2:2",
                        "1:2"});
            table3.AddRow(new string[] {
                        "0:0",
                        "1:2"});
#line 24
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table3, "And ");
#line 30
 testRunner.And("l\'index tiré aléatoirement est 2", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table4.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 32
 testRunner.Then("le déplacement choisi est", ((string)(null)), table4, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Déplacement choisi parmi 1 déplacements")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void DeplacementChoisiParmi1Deplacements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Déplacement choisi parmi 1 déplacements", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 37
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 38
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table5.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 39
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table5, "And ");
#line 42
 testRunner.And("l\'index tiré aléatoirement est 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table6.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 44
 testRunner.Then("le déplacement choisi est", ((string)(null)), table6, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Index tiré trop grand")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void IndexTireTropGrand()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Index tiré trop grand", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 50
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 51
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table7.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table7.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table7.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 52
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table7, "And ");
#line 57
 testRunner.And("l\'index tiré aléatoirement est 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 58
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table8.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 59
 testRunner.Then("le déplacement choisi est", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Déplacement choisi parmi 0 déplacement")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void DeplacementChoisiParmi0Deplacement()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Déplacement choisi parmi 0 déplacement", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 65
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 66
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
#line 67
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table9, "And ");
#line 69
 testRunner.And("l\'index tiré aléatoirement est 10", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
 testRunner.Then("le déplacement choisi est vide", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 déplacements choisis parmi 3 déplacements pour la même situation après une défa" +
            "ite.")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void _2DeplacementsChoisisParmi3DeplacementsPourLaMemeSituationApresUneDefaite_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 déplacements choisis parmi 3 déplacements pour la même situation après une défa" +
                    "ite.", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 75
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 76
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table10.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table10.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table10.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 77
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table10, "And ");
#line 82
 testRunner.And("l\'index tiré aléatoirement est 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table11.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 84
 testRunner.Then("le déplacement choisi est", ((string)(null)), table11, "Then ");
#line 87
 testRunner.And("Je perd la partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table12 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table12.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 90
 testRunner.Then("le déplacement choisi est", ((string)(null)), table12, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 déplacements choisis parmi 3 déplacements pour la même situation après une vict" +
            "oire.")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void _2DeplacementsChoisisParmi3DeplacementsPourLaMemeSituationApresUneVictoire_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 déplacements choisis parmi 3 déplacements pour la même situation après une vict" +
                    "oire.", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 96
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 97
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table13 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table13.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table13.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table13.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 98
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table13, "And ");
#line 103
 testRunner.And("l\'index tiré aléatoirement est 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table14 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table14.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 105
 testRunner.Then("le déplacement choisi est", ((string)(null)), table14, "Then ");
#line 108
 testRunner.And("Je gagne la partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table15 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table15.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 111
 testRunner.Then("le déplacement choisi est", ((string)(null)), table15, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 déplacements choisis parmi 1 déplacement pour la même situation après une défai" +
            "te.")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void _2DeplacementsChoisisParmi1DeplacementPourLaMemeSituationApresUneDefaite_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 déplacements choisis parmi 1 déplacement pour la même situation après une défai" +
                    "te.", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 117
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 118
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table16 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table16.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 119
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table16, "And ");
#line 122
 testRunner.And("l\'index tiré aléatoirement est 0", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table17 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table17.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 124
 testRunner.Then("le déplacement choisi est", ((string)(null)), table17, "Then ");
#line 127
 testRunner.And("Je gagne la partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 128
 testRunner.And("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 129
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table18 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table18.AddRow(new string[] {
                        "2:0",
                        "1:0"});
#line 130
 testRunner.Then("le déplacement choisi est", ((string)(null)), table18, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("2 déplacements choisis parmi 3 déplacements pour une situation différente après u" +
            "ne défaite.")]
        [NUnit.Framework.CategoryAttribute("JoueurIAMachineLearningTest")]
        public virtual void _2DeplacementsChoisisParmi3DeplacementsPourUneSituationDifferenteApresUneDefaite_()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("2 déplacements choisis parmi 3 déplacements pour une situation différente après u" +
                    "ne défaite.", null, new string[] {
                        "JoueurIAMachineLearningTest"});
#line 136
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 137
 testRunner.Given("Je vois ce plateau VVV___RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table19 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table19.AddRow(new string[] {
                        "2:0",
                        "1:0"});
            table19.AddRow(new string[] {
                        "2:1",
                        "1:1"});
            table19.AddRow(new string[] {
                        "2:2",
                        "1:2"});
#line 138
 testRunner.And("J\'ai ces déplacements disponibles", ((string)(null)), table19, "And ");
#line 143
 testRunner.And("l\'index tiré aléatoirement est 1", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 144
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table20 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table20.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 145
 testRunner.Then("le déplacement choisi est", ((string)(null)), table20, "Then ");
#line 148
 testRunner.And("Je perd la partie", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.And("Je vois ce plateau V_V_V_RRR", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 150
 testRunner.When("Je choisie un déplacement", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table21 = new TechTalk.SpecFlow.Table(new string[] {
                        "depart",
                        "fin"});
            table21.AddRow(new string[] {
                        "2:1",
                        "1:1"});
#line 151
 testRunner.Then("le déplacement choisi est", ((string)(null)), table21, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
