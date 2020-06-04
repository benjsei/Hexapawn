using TechTalk.SpecFlow;
using Moq;
using Hexapawn.Jeu;
using Hexapawn.Jeu.Partie;
using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau;

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
            aleatoire.Setup(a => a.RecupererVraiOuFaux()).Returns(nom == "Thomas");
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
            plateau.SetupSequence(a => a.EstPasTerminee)
                .Returns(true)
                .Returns(false);
            partie.Jouer();
        }

        [Then(@"Le joueur gagnant affiché est (.*)")]
        public void ThenLeJoueurGagnantAfficheEstThomas(string nom)
        {
            var gagnant = nom == "Thomas" ? joueurHaut : joueurBas;
            partieInterface.Verify(a => a.AfficherResultat(gagnant), Times.AtMostOnce());
        }

        [Then(@"(.*) coups ont été joués")]
        public void ThenToursSontPasses(int nombredecoups)
        {
            
            plateau.Verify(a => a.PasserAuJoueurSuivant(), Times.Exactly(nombredecoups - 1));
        }

        [Then(@"Les joueurs apprennent")]
        public void ThenLesJoueursApprennent()
        {
            plateau.Verify(a => a.Enseigner(), Times.Once());
        }

    }
}
