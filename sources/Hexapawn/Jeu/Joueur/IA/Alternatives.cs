using System.Collections.Generic;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.IA
{
    public class Alternatives : List<Alternative>
    {
        private Choix dernierChoix;

        //CLEAN CODE : StepDown Rule
        //Nous voulons que le code puisse se lire du début à la fin comme un réc
        //it Nous voulons que chaque fonction soit suivie des fonctions de niveau d’abstraction
        //inférieure, afin que nous puissions lire le programme en descendant d’un niveau
        //d’abstraction à la fois alors que nous parcourons la liste des fonctions vers le bas.

        public void SupprimerDernierChoix()
        {
            //CLEAN CODE : Single Responsability - Cette méthode enumére
            foreach (Alternative alternative in this)
            {
                //CLEAN CODE : Pour garder, 1 seule instruction intelligente dans une méthode (foreach)
                //le If est déporté dans une privée
                SupprimerSiMemePlateauEtNEstPasLaDerniere(alternative);
            }
            //CLEAN CODE : Un bon indicateur de la complexité d'une méthode est l'indentation max (ici 1)
            // il faut rester sous 3
        }

        public Deplacement ChoisirDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            var alternativesForPlateau = this.FindAll(alternative => alternative.Plateau == plateau);
            foreach (Alternative alternative in alternativesForPlateau)
            {
                if (alternative.Plateau == plateau)
                {
                    dernierChoix = alternative.Choisir();
                    return dernierChoix.Deplacement;
                }
            }

            return EnregistrerEtChoisirAleatoirementDeplacement(plateau, deplacementsPossibles, aleatoire);

            //CLEAN CODE : Ici on garde le IF car on ne peut pas faire sans pour casser le foreach sous condition
            //Une Solution ?
            /*foreach (Alternative alternative in this)
            {
                //CLEAN CODE : Ici on garde le IF car on ne peut pas faire sans pour casser le foreach sous condition
                //Une Solution ? 
                if (alternative.Plateau == plateau)
                {
                    dernierChoix = alternative.Choisir();
                    return dernierChoix.Deplacement;
                }
            }

            return EnregistrerEtChoisirAleatoirementDeplacement(plateau, deplacementsPossibles, aleatoire);*/
        }

        public Deplacement EnregistrerEtChoisirAleatoirementDeplacement(string plateau, Deplacement[] deplacementsPossibles, IAleatoire aleatoire)
        {
            Alternative alternative = new Alternative(plateau, deplacementsPossibles, aleatoire);
            this.Add(alternative);

            dernierChoix = alternative.Choisir();
            return dernierChoix.Deplacement;
        }

        private void SupprimerSiMemePlateauEtNEstPasLaDerniere(Alternative alternative)
        {
            //CLEAN CODE : On peut sortir un variable local pour commenter 
            var estMemePlateauEtNEstPasLaDerniere = dernierChoix.EstMemePlateau(alternative.Plateau)
                    && (alternative.APlusieursDeplacementsRestants);

            if (estMemePlateauEtNEstPasLaDerniere)
            {
                alternative.Deplacements.Remove(dernierChoix.Deplacement);
            }
        }
    }

}
