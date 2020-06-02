using System.Linq;
using Hexapawn;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Moq;

namespace HexapawnBDD
{
    [Binding]
    public class PartieTest
    {
        private readonly Mock<IAleatoire> aleatoire = new Mock<IAleatoire>();
        private readonly Mock<IPartieInterface> partieInterface = new Mock<IPartieInterface>();
        private readonly Joueur joueurHaut = new Joueur("Thomas", "V");
        private readonly Joueur joueurBas = new Joueur("Paul", "R");
        private Partie partie;
        private Mock<Plateau> plateau;

        [Given(@"La partie est prête à commencer")]
        public void GivenLaPartieEstPreteACommencer()
        {
            plateau = new Mock<Plateau>(joueurHaut, joueurBas)
            {
                CallBase = true
            };
            partie = new Partie(plateau.Object, partieInterface.Object, aleatoire.Object);
        }

        [Given(@"Le tirage au sort designe le joueur (.*) pour commencer")]
        public void GivenLeTirageAuSortDesigneLeJoueurThomasPourCommencer(string nom)
        {
            aleatoire.Setup(a => a.VraiOuFauxAleatoire()).Returns(nom == "Thomas");
        }

        [When(@"Un joueur gagne au premier coup")]
        public void WhenUnJoueurGagneAuPremierCoup()
        {
            plateau.Setup(a => a.Gagnant).Returns(joueurHaut);
            partie.Jouer();
        }

        [When(@"Un joueur gagne au second coup")]
        public void WhenUnDesJoueursGagneAuSecond()
        {
            plateau.SetupSequence(a => a.Gagnant)
                .Returns((Joueur)null)
                .Returns(joueurBas);
            partie.Jouer();
        }

        [Then(@"Le joueur gagnant affiché est (.*)")]
        public void ThenLeJoueurGagnantAfficheEstThomas(string nom)
        {
            var gagnant = nom == "Thomas" ? joueurHaut : joueurBas;
            partieInterface.Verify(a => a.AfficherResultat(gagnant), Times.Once());
        }

        [Then(@"(.*) coups ont été joués")]
        public void ThenToursSontPasses(int nombredecoups)
        {
            
            plateau.Verify(a => a.AuJoueurSuivant(), Times.Exactly(nombredecoups));
        }

        [Then(@"Les joueurs apprennent")]
        public void ThenLesJoueursApprennent()
        {
            plateau.Verify(a => a.Enseigner(), Times.Once());
        }

    }
}
