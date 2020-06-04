using System;
using Hexapawn.Jeu.Plateau;

namespace HexapawnBDD
{
    public class DeplacementString
    {
        public string Depart { get; set; }
        public string Fin { get; set; }

        public DeplacementString(string Depart, string Fin)
        {
            this.Depart = Depart;
            this.Fin = Fin;
        }

        public Deplacement EnDeplacement()
        {
            return new Deplacement(
                Depart,
                Fin);
        }
    }
}
