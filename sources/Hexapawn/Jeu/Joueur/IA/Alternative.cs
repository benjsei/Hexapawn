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
                //CLEAN CODE : Ici on aurait pu mettre return Deplacements.Count > 1; Mais ca aurait été moins documenté, et
                //le magic string 1 était difficle à éliminer.
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
