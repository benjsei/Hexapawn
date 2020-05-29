using System;
using Hexapawn;
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
        private readonly Aleatoire aleatoire = new Aleatoire();

        [Given(@"Je suis un joueur en bas du plateau")]
        public void GivenJeSuisUnJoueurEnBasDuPlateau()
        {
            joueur = new Joueur("Paul", "V", aleatoire)
            {
                sensDeJeu = SensDeJeu.BasVersHaut
            };
        }

        [Given(@"Je suis un joueur en haut du plateau")]
        public void GivenJeSuisUnJoueurEnHautDuPlateau()
        {
            joueur = new Joueur("Thomas", "R", aleatoire)
            {
                sensDeJeu = SensDeJeu.HautVersBas
            };
        }

        [When(@"J'avance mon pion")]
        public void WhenJavanceMonPion()
        {
            
        }

        [Then(@"mon pion se déplace vers le haut")]
        public void ThenMonPionSeDeplaceVersLeHaut()
        {
            Assert.AreEqual(joueur.IncrementDeplacement, IncrementVersLeHaut);
        }

        [Then(@"mon pion se déplace vers le bas")]
        public void ThenMonPionSeDeplaceVersLeBas()
        {
            Assert.AreEqual(joueur.IncrementDeplacement, IncrementVersLeBas);
        }
    }
}
