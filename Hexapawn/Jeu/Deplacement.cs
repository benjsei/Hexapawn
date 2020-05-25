using System;
namespace Hexapawn
{
    public class Deplacement
    {
        const string separtor = ":";

        public Position Depart { get; set; }
        public Position Fin { get; set; }

        public Deplacement(Position Depart, Position Fin)
        {
            this.Depart = Depart;
            this.Fin = Fin;
        }

        public Deplacement(String CoordoneesDepart, String CoordoneesFin)
        {
            this.Depart = new Position(CoordoneesDepart);
            this.Fin = new Position(CoordoneesFin);
        }

        override public string ToString()
        {
            return Depart + separtor + Fin;
        }

        public override bool Equals(object ob)
        {
            if (ob is Deplacement deplacement)
            {
                return Depart.Equals(deplacement.Depart) &&
                    Fin.Equals(deplacement.Fin);
            }

            return false;
        }

    }

}
