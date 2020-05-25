using System;
using System.Linq;
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
        private Joueur joueurHaut;
        private Joueur joueurBas;

        [Given("Je veux commencer une partie de Hexapawn")]
        public void GivenJeVeuxCommencerUnePartieDeHexapawn()
        {

      
        }

        [Given(@"Le joueur du haut est (.*), et il joue les pions (.*)")]
        public void GivenLeJoueurDuHautEstThomasEtIlJoueLesPionsR(string nom, string pion)
        {
            joueurHaut = new Joueur(nom, pion);
        }

 
        [Given(@"Le joueur du bas est (.*), et il joue les pions (.*)")]
        public void GivenLeJoueurDuBasEstPaulEtIlJoueLesPionsV(string nom, string pion)
        {
            joueurBas = new Joueur(nom, pion);
        }

        [Given("ils démarrent une nouvelle partie")]
        public void GivenJeDemarreUneNouvellePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [When("ils démarrent une nouvelle partie")]
        public void WhenJeDemarreUnePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [When("Thomas bouge son pion de (.*):(.*) à (.*):(.*)")]
        public void WhenJAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {
            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            plateau.BougerPion(joueurHaut, depart, arrivee);
        }


        [Then(@"Paul peut bouger en")]
        public void ThenPaulPeutBougerEn(Table table)
        {
           var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementsAttendus = deplacementStrings
                 .Select(deplacementString => deplacementString.enDeplacement());

            var deplacementsPossibles = plateau.DeplacementsPossibles(joueurBas);

            Assert.AreEqual(deplacementsAttendus, deplacementsPossibles);
        }

        [Then("ils voient ce plateau (.*)")]
        public void ThenJeVoisCePlateau(string PlateauAttendu)
        {
            var result = plateau.Afficher();

            Assert.AreEqual(PlateauAttendu, result);

        }

        [Then(@"Thomas peut bouger en")]
        public void ThenThomasPeutBougerEn(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementsAttendus = deplacementStrings
                 .Select(deplacementString => deplacementString.enDeplacement());

            var deplacementsPossibles = plateau.DeplacementsPossibles(joueurHaut);

            Assert.AreEqual(deplacementsAttendus, deplacementsPossibles);
        }
    }
}
