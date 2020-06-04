namespace Hexapawn.Jeu.Plateau
{
    public class Deplacement
    {
        const string separateur = " ";

        public Position Depart { get; set; }
        public Position Fin { get; set; }

        public Deplacement(Position depart, Position fin)
        {
            this.Depart = depart;
            this.Fin = fin;
        }

        public Deplacement(string coordoneesDepart, string coordoneesFin)
        {
            this.Depart = new Position(coordoneesDepart);
            this.Fin = new Position(coordoneesFin);
        }

        public override string ToString()
        {
            return Depart + separateur + Fin;
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
