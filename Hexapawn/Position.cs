using System;
namespace Hexapawn
{
    public class Position
    {
        public int Ligne = 0;
        public int Colonne = 0;

        public Position(int Ligne, int Colonne)
        {
            this.Colonne = Colonne;
            this.Ligne = Ligne;
        }
    }
}
