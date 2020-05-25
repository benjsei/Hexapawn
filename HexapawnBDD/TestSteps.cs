using System;
using Hexapawn;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD
{
    [Binding]
    public class TestSteps
    {

        private Plateau plateau;

        [Given("Je veux commencer une partie de Hexapawn")]
        public void GivenJeVeuxCommencerUnePartieDeHexapawn()
        {

      
        }

        [Given("Je démarre une nouvelle partie")]
        public void GivenJeDemarreUneNouvellePartie()
        {
            plateau = new Plateau();
        }

        [When("Je démarre une nouvelle partie")]
        public void WhenJeDemarreUnePartie()
        {
            plateau = new Plateau();
        }

        [When("Je bouge mon pion de (.*):(.*) à (.*):(.*)")]
        public void WhenJAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {

            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            plateau.BougerPionJoueur(depart, arrivee);
        }


        [Then(@"l'IA peut bouger en")]
        public void ThenIAPeutBougerEn(Table table)
        {
            var deplacementsAttendus = table.CreateSet<Deplacement>();
            var deplacementDonnees = plateau.ListerDeplacementPossibles();

            Assert.AreEqual(deplacementsAttendus, deplacementDonnees);
        }

        [Then("je vois ce plateau (.*)")]
        public void ThenJeVoisCePlateau(string PlateauAttendu)
        {
            var result = plateau.Afficher();

            Assert.AreEqual(PlateauAttendu, result);

        }
    }
}
