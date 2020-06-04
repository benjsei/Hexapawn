using System;
using Hexapawn.Jeu;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD.BDD.Jeu
{
    [Binding]
    public class AleatoireTest
    {
        private Aleatoire aleatoire = new Aleatoire();
        private int max;
        private int chiffreResultat;
        private bool vraiOuFauxResultat;

        [Given(@"Je veux un entier inférieur à (.*)")]
        public void GivenJeVeuxUnEntierInferieurA(int max)
        {
            this.max = max;
        }

        [Given(@"Je veux tirer à pile ou face")]
        public void GivenJeVeuxTirerAPileOuFace()
        {
           
        }

        [When(@"Je génére un entier")]
        public void WhenJeGenereUnEntier()
        {
            chiffreResultat = aleatoire.RecupererEntier(max);
        }

        [When(@"Je lance la pièce")]
        public void WhenJeLanceLaPiece()
        {
            vraiOuFauxResultat = aleatoire.RecupererVraiOuFaux();
        }

        [Then(@"L'entier est inférieur au maximum")]
        public void ThenLEntierEstInferieurAuMaximum()
        {
            Assert.Less(chiffreResultat, max);
        }

        [Then(@"L'entier est supérieur à 0")]
        public void ThenLEntierEstSuperieurAZero()
        {
            Assert.GreaterOrEqual(chiffreResultat, 0);
        }

        [Then(@"J'obtiens pile ou face")]
        public void ThenJobtiensPileOuFace()
        {
            Assert.IsNotNull(vraiOuFauxResultat);
        }
    }
}
