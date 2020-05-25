using System;
namespace Hexapawn
{
    public class Deplacement
    {
        public string Depart { get; set; }
        public string Fin { get; set; }

        public Deplacement(string Depart, string Fin)
        {
            this.Depart = Depart;
            this.Fin = Fin;
        }
    }
}
