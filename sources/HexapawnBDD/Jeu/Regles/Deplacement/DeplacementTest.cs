using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD
{
    [Binding]
    public class DeplacementTest
    {
        private Plateau plateau;
        private Joueur joueurHaut;
        private Joueur joueurBas;

        [Given(@"Le joueur du haut est (.*), et il joue les pions (.*)"), Scope(Tag = "DeplacementTest")]
        public void GivenLeJoueurDuHautEstThomasEtIlJoueLesPionsR(string nom, string pion)
        {
            joueurHaut = new Joueur(nom, pion);
        }


        [Given(@"Le joueur du bas est (.*), et il joue les pions (.*)"), Scope(Tag = "DeplacementTest")]
        public void GivenLeJoueurDuBasEstPaulEtIlJoueLesPionsV(string nom, string pion)
        {
            joueurBas = new Joueur(nom, pion);
        }

        [Given("ils démarrent une nouvelle partie"), Scope(Tag = "DeplacementTest")]
        public void GivenJeDemarreUneNouvellePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [When("Thomas bouge son pion de (.*):(.*) à (.*):(.*)"), Scope(Tag = "DeplacementTest")]
        public void WhenThomasAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {
            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            Deplacement deplacement = new Deplacement(depart, arrivee);

            plateau.JoueurActif = joueurHaut;
            plateau.BougerPion(joueurHaut, deplacement);
        }


        [Then("ils voient ce plateau (.*)"), Scope(Tag = "DeplacementTest")]
        public void ThenJeVoisCePlateau(string PlateauAttendu)
        {
            var result = plateau.Afficher();

            Assert.AreEqual(PlateauAttendu, result);

        }

    }
}
