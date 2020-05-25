using System;
namespace Hexapawn
{
    public class Partie
    {
        public Joueur joueurHaut;
        public Joueur joueurBas;

        public Partie(Joueur joueurHaut, Joueur joueurBas)
        {
            this.joueurHaut = joueurHaut;
            this.joueurBas = joueurBas;
        }
    }
}
