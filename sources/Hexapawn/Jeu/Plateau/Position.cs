using System;
namespace Hexapawn.Jeu.Plateau
{
    public class Position
    {
        private const char separateur = ':';

        public int Ligne = 0;
        public int Colonne = 0;

        public Position(int ligne, int colonne)
        {
            this.Colonne = colonne;
            this.Ligne = ligne;
        }

        public Position(string coordonnees)
        {
            var positions = coordonnees.Split(separateur);

            this.Ligne = Convert.ToInt32(positions[0]);
            this.Colonne = Convert.ToInt32(positions[1]);
        }

        public override bool Equals(object ob)
        {
            if (ob is Position position)
            {
                return Ligne == position.Ligne &&
                    Colonne == position.Colonne;
            }

            return false;
        }
        
        public override string ToString()
        {
            return Ligne.ToString() + separateur + Colonne.ToString();
        }
    }
}
