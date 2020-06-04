using System.Linq;
using Hexapawn.Jeu.Joueur;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurIAMachineLearningTest
    {
        private readonly Joueur joueurIA = new JoueurIAMachineLearning("Paul", "V", new AleatoireMock());
        private readonly Joueur joueur2 = new Joueur("Thomas", "R");
        private Deplacement[] deplacementsPossibles;
        private Deplacement deplacementChoisi;
        private Plateau plateau;

        [Given(@"J'ai ces déplacements disponibles"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void GivenJaiCesDeplacementsDisponibles(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            deplacementsPossibles = deplacementStrings
                .Select(deplacementString => deplacementString.EnDeplacement())
                .ToArray();
        }

        [Given(@"l'index tiré aléatoirement est (.*)"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void GivenLindexTireAleatoirementEst(int ChiffreAleatoire)
        {
            AleatoireMock.ChiffreAleatoireRetour = ChiffreAleatoire;
        }

        [Given(@"Je vois ce plateau (.*)")]
        public void GivenJeVoisCePlateauVVV___RRRR(string plateau)
        {
            this.plateau = new Plateau(joueurIA, joueur2);
            this.plateau.Restaurer(plateau);
        }

        [When(@"Je choisie un déplacement"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void WhenJeChoisieUnDeplacement()
        {
            deplacementChoisi = joueurIA.ChoisirDeplacement(plateau, deplacementsPossibles);
        }

        [Then(@"Je gagne la partie"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void ThenJeGagneLaPartie()
        {
            joueurIA.Apprendre(true);
        }

        [Then(@"Je perd la partie"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void ThenJePerdLaPartie()
        {
            joueurIA.Apprendre(false);
        }

        [Then(@"Je vois ce plateau (.*)")]
        public void ThenJeVoisCePlateauVVV___RRRR(string plateau)
        {
            this.plateau.Restaurer(plateau);
        }

        [Then(@"le déplacement choisi est"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void ThenLeDeplacementChoisiEst(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementAttendu = (deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement()))
                 .ToArray()[0];

            Assert.AreEqual(deplacementChoisi, deplacementAttendu);
        }

        [Then(@"le déplacement choisi est vide"), Scope(Tag = "JoueurIAMachineLearningTest")]
        public void ThenLeDeplacementChoisiEstVide()
        {
            Assert.IsNull(deplacementChoisi);
        }
    }
}
