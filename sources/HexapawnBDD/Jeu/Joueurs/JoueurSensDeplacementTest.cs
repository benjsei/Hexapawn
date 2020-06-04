using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurSensDeplacementTest
    {
        private Joueur joueur;
        private const int IncrementVersLeHaut = -1;
        private const int IncrementVersLeBas = 1;
        private Position depart = new Position(0, 0);
        private Position nouvellePosition;

        [Given(@"Je suis un joueur en bas du plateau")]
        public void GivenJeSuisUnJoueurEnBasDuPlateau()
        {
            joueur = new Joueur("Paul", "V")
            {
                sensDeJeu = SensDeJeu.BasVersHaut
            };
        }

        [Given(@"Je suis un joueur en haut du plateau")]
        public void GivenJeSuisUnJoueurEnHautDuPlateau()
        {
            joueur = new Joueur("Thomas", "R")
            {
                sensDeJeu = SensDeJeu.HautVersBas
            };
        }

        [When(@"J'avance mon pion")]
        public void WhenJavanceMonPion()
        {
            nouvellePosition = joueur.AvancerPosition(depart);
        }

        [Then(@"mon pion se déplace vers le haut")]
        public void ThenMonPionSeDeplaceVersLeHaut()
        {
            Assert.AreEqual(nouvellePosition.Ligne, IncrementVersLeHaut);
        }

        [Then(@"mon pion se déplace vers le bas")]
        public void ThenMonPionSeDeplaceVersLeBas()
        {
            Assert.AreEqual(nouvellePosition.Ligne, IncrementVersLeBas);
        }
    }
}
