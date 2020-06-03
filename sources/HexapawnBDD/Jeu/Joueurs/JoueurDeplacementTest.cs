using System.Linq;
using Hexapawn;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurDeplacementTest
    {
        private readonly Joueur joueur = new Joueur("Paul", "V");
        private Deplacement[] deplacementsPossibles;
        private Deplacement deplacementChoisi;

        [Given(@"J'ai ces déplacements disponibles"), Scope(Tag = "JoueurDeplacementTest")]
        public void GivenJaiCesDeplacementsDisponibles(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

             deplacementsPossibles = deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement())
                 .ToArray();
        }

        [When(@"Je choisie un déplacement"), Scope(Tag = "JoueurDeplacementTest")]
        public void WhenJeChoisieUnDeplacement()
        {
            deplacementChoisi = joueur.ChoisirDeplacement(null, deplacementsPossibles);
        }

        [Then(@"le déplacement choisi est"), Scope(Tag = "JoueurDeplacementTest")]
        public void ThenLeDeplacementChoisiEst(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementAttendu = (deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement()))
                 .ToArray()[0];

            Assert.AreEqual(deplacementChoisi, deplacementAttendu);
        }

        [Then(@"le déplacement choisi est vide"), Scope(Tag = "JoueurDeplacementTest")]
        public void ThenLeDeplacementChoisiEstVide()
        {
            Assert.IsNull(deplacementChoisi);
        }

    }
}
