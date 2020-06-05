using System.Collections.Generic;
using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.IA
{
    public class Alternative
    {

        private string Plateau;

        public List<Deplacement> Deplacements;

        private readonly IAleatoire aleatoire;

        public Alternative(string Plateau, Deplacement[] Deplacements, IAleatoire aleatoire)
        {
            this.Plateau = Plateau;
            this.Deplacements = new List<Deplacement>(Deplacements);
            this.aleatoire = aleatoire;
        }

        public Choix Choisir()
        {
            Deplacement deplacement = ChoisirDeplacement();
            return new Choix(Plateau, deplacement);
        }

        public bool APlusieursDeplacementsRestants
        {
            get
            {
                return Deplacements.AAuMoinsDeux();
            }
        }

        public bool EstMemePlateau(string plateau)
        {
            return Plateau == plateau;
        }

        private Deplacement ChoisirDeplacement()
        {
            int indexAleatoire = aleatoire.RecupererEntier(Deplacements.Count);

            if (indexAleatoire < Deplacements.Count)
            {
                return Deplacements[indexAleatoire];
            }
            return (Deplacement)Deplacements.ToArray().PremierSinonVide();
        }
    }

}
