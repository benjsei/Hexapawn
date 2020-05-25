using System;

namespace Hexapawn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Joueur joueurHaut = new Joueur("Thomas", "R");
            Joueur joueurBas = new Joueur("Paul", "V");

            Plateau plateau = new Plateau(joueurHaut, joueurBas);
            plateau.Afficher();
            Console.WriteLine("Plateau : "+plateau.Afficher());

        }
    }
}
