using Hexapawn.Jeu.Joueur;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD
{
    [Binding]
    public class ReglesTestSteps
    {

        private Plateau plateau;
        private Joueur joueurHaut;
        private Joueur joueurBas;

        [Given(@"Le joueur du haut est (.*), et il joue les pions (.*)"), Scope(Tag = "MiseEnPlaceTest")]
        public void GivenLeJoueurDuHautEstThomasEtIlJoueLesPionsR(string nom, string pion)
        {
            joueurHaut = new Joueur(nom, pion);
        }

 
        [Given(@"Le joueur du bas est (.*), et il joue les pions (.*)"), Scope(Tag = "MiseEnPlaceTest")]
        public void GivenLeJoueurDuBasEstPaulEtIlJoueLesPionsV(string nom, string pion)
        {
            joueurBas = new Joueur(nom, pion);
        }

        [When("ils démarrent une nouvelle partie"), Scope(Tag = "MiseEnPlaceTest")]
        public void WhenJeDemarreUnePartie()
        {
            plateau = new Plateau(joueurHaut, joueurBas);
        }

        [Then("ils voient ce plateau (.*)"), Scope(Tag = "MiseEnPlaceTest")]
        public void ThenJeVoisCePlateau(string PlateauAttendu)
        {
            var result = plateau.Afficher();

            Assert.AreEqual(PlateauAttendu, result);

        }
    }
}
