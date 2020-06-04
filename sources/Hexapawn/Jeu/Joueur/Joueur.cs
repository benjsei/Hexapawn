using System;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs
{
    public class Joueur
    {
        public readonly string nom;
        public readonly string pion;
        public SensDeJeu sensDeJeu;

        private int victoire = 0;
        private int partie = 0;

        ///CLEAN CODE : Le wording de l'application doit être dans un fichier ressource.
        private const string palmaresFormat = "{0} : {1} Victoire(s) pour {2} Combat(s) ({3:0.00}%).";
        private const int incrementDeDeplacement = 1;

        public Joueur(string nom, string pion)
        {
            this.nom = nom;
            this.pion = pion;
        }

        public Position AvancerPosition(Position depart)
        {
            int nouvelleLigne = depart.Ligne + IncrementDeplacement;

            return new Position(nouvelleLigne, depart.Colonne);
        }

        public virtual Deplacement ChoisirDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles)
        {
            return (Deplacement)deplacementsPossibles.PremierSinonVide();
        }

        public virtual void Apprendre(bool estVictoire)
        {
            partie++;
            ///CLEAN CODE : Toujours des conditions positives.
            if (estVictoire)
            {
                victoire++;
            }
        }

        public string Palmares
        {
            get
            {
                return string.Format(palmaresFormat,
                    nom,
                    victoire,
                    partie,
                    PourcentageVictoire);
            }
        }

        private int IncrementDeplacement
        {
            get
            {
                if (sensDeJeu == SensDeJeu.BasVersHaut)
                {
                    return incrementDeDeplacement.Inverser();
                }

                return incrementDeDeplacement;
            }
        }

        private double PourcentageVictoire
        {
            get
            {
                ///CLEAN CODE : On évite le magic string 0 pour expliciter le code.
                if (partie.DifferentZero())
                {
                    return (Convert.ToDouble(victoire) / Convert.ToDouble(partie)).PourCent();
                }

                return IntExtension.zeroValue;
            }
        }
    }
}
