using System.Linq;
using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurAleatoireTest
    {
        private readonly Joueur joueur = new JoueurAleatoire("Paul", "V", new AleatoireMock());
        private Deplacement[] deplacementsPossibles;
        private Deplacement deplacementChoisi;

        [Given(@"J'ai ces déplacements disponibles"), Scope(Tag = "JoueurAleatoireTest")]
        public void GivenJaiCesDeplacementsDisponibles(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            deplacementsPossibles = deplacementStrings
                .Select(deplacementString => deplacementString.EnDeplacement())
                .ToArray();
        }

        [Given(@"l'index tiré aléatoirement est (.*)"), Scope(Tag = "JoueurAleatoireTest")]
        public void GivenLindexTireAleatoirementEst(int ChiffreAleatoire)
        {
            AleatoireMock.ChiffreAleatoireRetour = ChiffreAleatoire;
        }

        [When(@"Je choisie un déplacement"), Scope(Tag = "JoueurAleatoireTest")]
        public void WhenJeChoisieUnDeplacement()
        {
            deplacementChoisi = joueur.ChoisirDeplacement(null, deplacementsPossibles);
        }

        [Then(@"le déplacement choisi est"), Scope(Tag = "JoueurAleatoireTest")]
        public void ThenLeDeplacementChoisiEst(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementAttendu = (deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement()))
                 .ToArray()[0];

            string objetQuelconque = "Nimportequoi";

            Assert.IsFalse(deplacementChoisi.Equals(objetQuelconque));
            Assert.IsFalse(deplacementChoisi.Fin.Equals(objetQuelconque));
            Assert.AreEqual(deplacementChoisi, deplacementAttendu);
        }

        [Then(@"le déplacement choisi est vide"), Scope(Tag = "JoueurAleatoireTest")]
        public void ThenLeDeplacementChoisiEstVide()
        {
            Assert.IsNull(deplacementChoisi);
        }
    }
}
