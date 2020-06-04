using Hexapawn.Jeu.Joueurs;
using Hexapawn.Jeu.Plateau.Regle;

namespace Hexapawn.Jeu.Plateau
{
    public class Plateau : IPlateau
    {
        //CLEAN CODE : Aucun MAGIC String
        //CLEAN CODE : Ne pas dévoiler le contenu de la classe. Les objets cachent leurs données et exposent des opérations.
        //CLEAN CODE : Déméter
        //  Ex . : Le code suivant3 transgresse la loi de Déméter (entre autres choses) car il appelle la fonction getScratchDir() sur la valeur de retour de getOptions() et invoque ensuite getAbsolutePath() sur la valeur de retour de getScratchDir().
        //  final String outputDir = ctxt.getOptions().getScratchDir().getAbsolutePath();

        private const int taille = 3;
        private readonly Joueur joueurHaut;
        private readonly Joueur joueurBas;
        private readonly Damier damier = new Damier(taille);
        private readonly ReglesDeplacement reglesDeplacement;
        private readonly ReglesVictoire reglesVictoire;

        public Joueur JoueurActif;

        public Plateau(Joueur joueurHaut, Joueur joueurBas)
        {
            joueurHaut.sensDeJeu = SensDeJeu.HautVersBas;
            this.joueurHaut = joueurHaut;

            joueurBas.sensDeJeu = SensDeJeu.BasVersHaut;
            this.joueurBas = joueurBas;

            reglesDeplacement = new ReglesDeplacement(damier);
            reglesVictoire = new ReglesVictoire(reglesDeplacement, damier);

            MettreEnPlace();
        }

        //CLEAN CODE : Formes unaires classiques
        public void SelectionnerJoueurActif(bool face)
        {
            JoueurActif = face ? joueurBas : joueurHaut;
        }

        //CLEAN CODE : Idéalement, le nombre d’arguments d’une fonction devrait être égal à zéro (niladique)
        public virtual void PasserAuJoueurSuivant()
        {
            JoueurActif = JoueurActif == joueurBas ? joueurHaut : joueurBas;
        }

        public void JouerJoueurActif()
        {
            Deplacement deplacement = JoueurActif.ChoisirDeplacement(this, reglesDeplacement.DeplacementsPossibles(JoueurActif));
            damier.BougerPion(JoueurActif.pion, deplacement);
        }
        //CLEAN CODE : Une fonction est toujours un verbe.
        public string Afficher()
        {
            return damier.Afficher();
        }

        public void Restaurer(string damier)
        {
            this.damier.Restaurer(damier);
        }

        //CLEAN CODE : Formes diadiques, ca passe, mais on doit déjà se questionner, Est-ce possible de faire autrement ?
        public void BougerPion(Joueur joueur, Deplacement deplacement)
        {
            damier.BougerPion(joueur.pion, deplacement);
        }

        // CLEAN CODE : Encapsulation
        // Nous préférons garder privées nos variables et nos fonctions utilitaires,
        // mais nous savons faire preuve de souplesse.Parfois,
        /// nous devons définir une variable ou une fonc- tion utilitaire protégée afin qu’un test puisse y accéder.
        /// Pour nous, les tests gouvernent.Si un test du même paquetage doit invoquer une fonction ou accéder à une variable,
        /// nous la déclarerons protégée ou la placerons dans la portée du paqueta
        /// ge. Cependant, nous rechercherons tout d’abord un moyen de la conserver privée.
        /// Nous ne relâchons l’encapsulation qu’en dernier ressort.
        /// Ici on a mis en public uniquement pour les tests, en attendant une meilleure solution.
        public Deplacement[] DeplacementsPossibles(Joueur joueur)
        {
            return reglesDeplacement.DeplacementsPossibles(joueur);
        }

        public virtual bool EstPasTerminee {
            get
            {
                return Gagnant == null;
            }
        }

        // CLEAN CODE : Attention -> 15 Lignes c'est déjà un gros bout de code
        public virtual Joueur Gagnant
        {
            get
            {
                // CLEAN CODE : 3 Ifs, ca commence à faire bcp, pouvons-nous faire autrement ?
                if (reglesVictoire.EstDetruit(ProchainJoueur))
                {
                    return JoueurActif;
                }
                // CLEAN CODE : Pas de Else ici, ils ne sont pas utiles, moins de code = moins de maintenance
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

        private Joueur ProchainJoueur
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
