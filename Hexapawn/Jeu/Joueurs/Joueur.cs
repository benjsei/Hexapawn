using System;
namespace Hexapawn
{
    public class Joueur
    {
        public readonly string nom;
        public readonly string pion;
        public SensDeJeu sensDeJeu;

        private int victoire = 0;
        private int partie = 0;
        private const string palmaresFormat = "{0} : {1} Victoire(s) pour {2} Combat(s) ({3:0.00}%).";
        private const int incrementDeDeplacement = 1;

        public Joueur(string nom, string pion)
        {
            this.nom = nom;
            this.pion = pion;
        }

        public int IncrementDeplacement
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

        public virtual Deplacement ChoisirDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
        {
            return (Deplacement)deplacementsPossibles.PremierSinonVide();
        }

        public virtual void Apprendre(bool estVictoire)
        {
            partie++;
            if (estVictoire)
            {
                victoire++;
            }
        }

        public string Palmares
        {
            get
            {
                return String.Format(palmaresFormat,
                    nom,
                    victoire,
                    partie,
                    PourcentageVictoire);
            }
        }

        private double PourcentageVictoire
        {
            get
            {
                if (partie.DifferentZero())
                {
                    return (Convert.ToDouble(victoire) / Convert.ToDouble(partie)).PourCent();
                }

                return IntExtension.zeroValue;
            }
        }
    }
}
