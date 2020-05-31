using System.Linq;
using Hexapawn;
using HexapawnBDD.Mock;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace HexapawnBDD.Jeu.Joueurs
{
    [Binding]
    public class JoueurHumainTest
    {

        private readonly Joueur joueur = new JoueurHumain("Paul", "V", new JoueurHumainInterfaceMock());
        private Deplacement[] deplacementsPossibles;
        private Deplacement deplacementChoisi;

        [Given(@"J'ai ces deplacements disponibles"), Scope(Tag = "JoueurHumain")]
        public void GivenJaiCesDeplacementsDisponibles(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            deplacementsPossibles = deplacementStrings
                .Select(deplacementString => deplacementString.EnDeplacement())
                .ToArray();
        }

        [Given(@"l'index tiré aléatoirement est (.*)"), Scope(Tag = "JoueurHumain")]
        public void GivenLindexTireAleatoirementEst(int ChiffreAleatoire)
        {
            AleatoireMock.ChiffreAleatoireRetour = ChiffreAleatoire;
        }

        [When(@"Je choisie un déplacement (.*)"), Scope(Tag = "JoueurHumain")]
        public void WhenJeChoisieUnDeplacement(int deplacementSaisi)
        {
            JoueurHumainInterfaceMock.DemanderDeplacementRetour = deplacementSaisi;

            deplacementChoisi = joueur.ChoisirDeplacement(null, deplacementsPossibles);
        }

        [Then(@"le déplacement choisi est"), Scope(Tag = "JoueurHumain")]
        public void ThenLeDeplacementChoisiEst(Table table)
        {
            var deplacementStrings = table.CreateSet<DeplacementString>();

            var deplacementAttendu = (deplacementStrings
                 .Select(deplacementString => deplacementString.EnDeplacement()))
                 .ToArray()[0];

            Assert.AreEqual(deplacementChoisi, deplacementAttendu);
        }

        [Then(@"le déplacement choisi est vide"), Scope(Tag = "JoueurHumain")]
        public void ThenLeDeplacementChoisiEstVide()
        {
            Assert.IsNull(deplacementChoisi);
        }
    }
}
