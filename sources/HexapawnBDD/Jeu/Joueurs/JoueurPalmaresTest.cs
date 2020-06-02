using System;
using Hexapawn;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurPalmaresTest
    {
        private Joueur joueur;

        [Given(@"Je suis Paul et je joue les pions V")]
        public void GivenJeSuisPaulEtJeJoueLesPionsV()
        {
            joueur = new Joueur("Paul", "V");
        }

        [Given(@"Je fais (.*) partie\(s\) gagnante\(s\)")]
        public void GivenJeFaisPartieSGagnanteS(int gagnante)
        {
            for(int i =0; i < gagnante; i++) {
                joueur.Apprendre(true);
            }
        }

        [Given(@"Je fais (.*) partie\(s\) perdante\(s\)")]
        public void GivenJeFaisPartieSPerdanteS(int perdante)
        {
            for (int i = 0; i < perdante; i++)
            {
                joueur.Apprendre(false);
            }
        }

        [When(@"J'affiche mon palamès")]
        public void WhenJafficheMonPalames()
        {

        }

        [Then(@"je vois (.*)")]
        public void ThenJeVois(string palmares)
        {
            Assert.AreEqual(joueur.Palmares, palmares);
        }
    }
}
