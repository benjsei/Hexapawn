using System.Linq;
using Hexapawn;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD
{
    [Binding]
    public class DeplacementsPossiblesTest
    {
        private Plateau plateau;
        private Joueur joueurHaut;
        private Joueur joueurBas;
        private readonly Aleatoire aleatoire = new Aleatoire();

        [Given(@"Le joueur du haut est (.*), et il joue les pions (.*)"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void GivenLeJoueurDuHautEstThomasEtIlJoueLesPionsR(string nom, string pion)
        {
            joueurHaut = new Joueur(nom, pion);
        }


        [Given(@"Le joueur du bas est (.*), et il joue les pions (.*)"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void GivenLeJoueurDuBasEstPaulEtIlJoueLesPionsV(string nom, string pion)
        {
            joueurBas = new Joueur(nom, pion);
        }

        [Given("ils démarrent une nouvelle partie"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void GivenJeDemarreUneNouvellePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [When("ils démarrent une nouvelle partie"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void WhenJeDemarreUnePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [When("Thomas bouge son pion de (.*):(.*) à (.*):(.*)"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void WhenThomasAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {
            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            Deplacement deplacement = new Deplacement(depart, arrivee);

            plateau.JoueurActif = joueurHaut;
            plateau.BougerPion(joueurHaut, deplacement);
        }

        [Then(@"Paul peut bouger en"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void ThenPaulPeutBougerEn(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementsAttendus = deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement());

            var deplacementsPossibles = plateau.DeplacementsPossibles(joueurBas);

            Assert.AreEqual(deplacementsAttendus, deplacementsPossibles);
        }

        [Then(@"Thomas peut bouger en"), Scope(Tag = "DeplacementsPossiblesTest")]
        public void ThenThomasPeutBougerEn(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementsAttendus = deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement());

            var deplacementsPossibles = plateau.DeplacementsPossibles(joueurHaut);

            Assert.AreEqual(deplacementsAttendus, deplacementsPossibles);
        }
    }
}
