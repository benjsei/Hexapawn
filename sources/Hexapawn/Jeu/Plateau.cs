namespace Hexapawn
{
    public class Plateau : IPlateau
    {
        private const int taille = 3;

        private readonly Joueur joueurHaut;
        private readonly Joueur joueurBas;

        public Joueur JoueurActif;
        private Joueur ProchainJoueur
        {
            get
            {
                if (JoueurActif == joueurHaut) {
                    return joueurBas;
                }

                return joueurHaut;
            }
        }

        private readonly Damier Damier = new Damier(taille);

        public Plateau(Joueur joueurHaut, Joueur joueurBas)
        {
            joueurHaut.sensDeJeu = SensDeJeu.HautVersBas;
            this.joueurHaut = joueurHaut;

            joueurBas.sensDeJeu = SensDeJeu.BasVersHaut;
            this.joueurBas = joueurBas;

            MettreEnPlace();
        }

        public void SelectionnerJoueurActif(bool face)
        {
            JoueurActif = face ? joueurBas : joueurHaut;
        }

      
        public virtual void AuJoueurSuivant()
        {
            JoueurActif = JoueurActif == joueurBas ? joueurHaut : joueurBas;
        }

        public void Jouer()
        {
            Deplacement deplacement = JoueurActif.ChoisirDeplacement(this, Damier.DeplacementsPossibles(JoueurActif));
            Damier.BougerPion(JoueurActif.pion, deplacement);
        }

        public string Afficher()
        {
            return Damier.Afficher();
        }

        public void Restaurer(string damier)
        {
            Damier.Restaurer(damier);
        }

        public void BougerPion(Joueur joueur, Deplacement deplacement)
        {
            Damier.BougerPion(joueur.pion, deplacement);
        }

        public Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            return Damier.DeplacementsPossibles(joueur);
        }

        public virtual bool EstPasTerminee {
            get
            {
                return Gagnant == null;
            }
        }

        public virtual Joueur Gagnant
        {
            get
            {
                if (Damier.EstDetruit(ProchainJoueur))
                {
                    return JoueurActif;
                }

                if (Damier.AConquis(JoueurActif))
                {
                    return JoueurActif;
                }

                if (Damier.EstBloque(ProchainJoueur))
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

        private void MettreEnPlace()
        {
            Damier.Vider();
            Damier.MettreEnPlace(joueurHaut);
            Damier.MettreEnPlace(joueurBas);
        }   
    }    
}
