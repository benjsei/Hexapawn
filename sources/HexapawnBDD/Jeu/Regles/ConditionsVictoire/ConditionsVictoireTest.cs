using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HexapawnBDD
{
    [Binding]
    public class ConditionsVictoireTest
    {
        private Plateau plateau;
        private Joueur joueurHaut;
        private Joueur joueurBas;

        [Given(@"Le joueur du haut est (.*), et il joue les pions (.*)"), Scope(Tag = "ConditionsVictoireTest")]
        public void GivenLeJoueurDuHautEstThomasEtIlJoueLesPionsR(string nom, string pion)
        {
            joueurHaut = new Joueur(nom, pion);
        }


        [Given(@"Le joueur du bas est (.*), et il joue les pions (.*)"), Scope(Tag = "ConditionsVictoireTest")]
        public void GivenLeJoueurDuBasEstPaulEtIlJoueLesPionsV(string nom, string pion)
        {
            joueurBas = new Joueur(nom, pion);
        }

        [Given(@"ils voient ce plateau (.*)"), Scope(Tag = "ConditionsVictoireTest")]
        public void GivenIlsVoientCePlateau_RRR___VV(string plateau)
        {
            this.plateau = new Plateau(joueurHaut, joueurBas);
            this.plateau.Restaurer(plateau);
        }

        [When("Thomas bouge son pion de (.*):(.*) à (.*):(.*)"), Scope(Tag = "ConditionsVictoireTest")]
        public void WhenThomasAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {
            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            Deplacement deplacement = new Deplacement(depart, arrivee);

            plateau.JoueurActif = joueurHaut;
            plateau.BougerPion(joueurHaut, deplacement);
        }

        [When("Paul bouge son pion de (.*):(.*) à (.*):(.*)"), Scope(Tag = "ConditionsVictoireTest")]
        public void WhenPaulAvanceLePion(int lignedepart, int coldepart, int lignearrivee, int colarrivee)
        {
            Position depart = new Position(lignedepart, coldepart);
            Position arrivee = new Position(lignearrivee, colarrivee);

            Deplacement deplacement = new Deplacement(depart, arrivee);

            plateau.JoueurActif = joueurBas;
            plateau.BougerPion(joueurBas, deplacement);
        }

        [Then(@"(.*) gagne la partie"), Scope(Tag = "ConditionsVictoireTest")]
        public void ThenThomasGagneLaPartie(string nom)
        {
            Assert.AreEqual(plateau.Gagnant.nom, nom);
        }
    }
}
