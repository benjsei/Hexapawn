using Hexapawn.Jeu.Joueur;
using Hexapawn.Jeu.Plateau.Regle;

namespace Hexapawn.Jeu.Plateau
{
    public class Plateau : IPlateau
    {
        private const int taille = 3;
        private readonly Joueur.Joueur joueurHaut;
        private readonly Joueur.Joueur joueurBas;
        private readonly Damier damier = new Damier(taille);
        private readonly ReglesDeplacement reglesDeplacement;
        private readonly ReglesVictoire reglesVictoire;

        public Joueur.Joueur JoueurActif;

        public Plateau(Joueur.Joueur joueurHaut, Joueur.Joueur joueurBas)
        {
            joueurHaut.sensDeJeu = SensDeJeu.HautVersBas;
            this.joueurHaut = joueurHaut;

            joueurBas.sensDeJeu = SensDeJeu.BasVersHaut;
            this.joueurBas = joueurBas;

            reglesDeplacement = new ReglesDeplacement(damier);
            reglesVictoire = new ReglesVictoire(reglesDeplacement, damier);

            MettreEnPlace();
        }

        public void SelectionnerJoueurActif(bool face)
        {
            JoueurActif = face ? joueurBas : joueurHaut;
        }


        public virtual void PasserAuJoueurSuivant()
        {
            JoueurActif = JoueurActif == joueurBas ? joueurHaut : joueurBas;
        }

        public void JouerJoueurActif()
        {
            Deplacement deplacement = JoueurActif.ChoisirDeplacement(this, reglesDeplacement.DeplacementsPossibles(JoueurActif));
            damier.BougerPion(JoueurActif.pion, deplacement);
        }

        public string Afficher()
        {
            return damier.Afficher();
        }

        public void Restaurer(string damier)
        {
            this.damier.Restaurer(damier);
        }

        public void BougerPion(Joueur.Joueur joueur, Deplacement deplacement)
        {
            damier.BougerPion(joueur.pion, deplacement);
        }

        public Deplacement[] DeplacementsPossibles(Joueur.Joueur joueur)
        {
            return reglesDeplacement.DeplacementsPossibles(joueur);
        }

        public virtual bool EstPasTerminee {
            get
            {
                return Gagnant == null;
            }
        }

        public virtual Joueur.Joueur Gagnant
        {
            get
            {
                if (reglesVictoire.EstDetruit(ProchainJoueur))
                {
                    return JoueurActif;
                }

                if (reglesVictoire.AConquis(JoueurActif))
                {
                    return JoueurActif;
                }

                if (reglesVictoire.EstBloque(ProchainJoueur))
                {
                    return JoueurActif;
                }

                return null;
            }
        }

        public virtual void Enseigner()
        {
            bool joueurBasGagnant = Gagnant == joueurBas;
            joueurBas.Apprendre(joueurBasGagnant);
            joueurHaut.Apprendre(!joueurBasGagnant);
        }

        private Joueur.Joueur ProchainJoueur
        {
            get
            {
                if (JoueurActif == joueurHaut)
                {
                    return joueurBas;
                }

                return joueurHaut;
            }
        }

        private void MettreEnPlace()
        {
            damier.Vider();
            damier.MettreEnPlace(joueurHaut);
            damier.MettreEnPlace(joueurBas);
        }   
    }    
}
