using System;
using System.Runtime.CompilerServices;

namespace Hexapawn
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPartieInterface partieInterface = new PartieInterface();
            IAleatoire aleatoire = new Aleatoire();
            IJoueurHumainInterface joueurHumainInterface = new JoueurHumainInterface();

            Joueur joueurHaut = new JoueurAleatoire("ThomasCoupDeChance", "R", aleatoire);
            Joueur joueurBas = new JoueurIAMachineLearning("PaulLIntello", "V", aleatoire);
            Joueur joueurHautHumain = new JoueurHumain("Moi", "R", joueurHumainInterface);
            //Joueur joueurBas = new JoueurAleatoire("Paul", "V");

            for(int i = 0; i < 1000; i++) {
                Partie partie = new Partie(joueurHaut, joueurBas, partieInterface, aleatoire);
                partie.Jouer();
            }

            Console.WriteLine("Terminée");

            Console.WriteLine(joueurHaut.Palmares);
            Console.WriteLine(joueurBas.Palmares);

            for (int i = 0; i < 1000; i++)
            {
                Partie partie = new Partie(joueurHaut, joueurBas, partieInterface, aleatoire);
                partie.Jouer();
            }

            Console.WriteLine("Terminée");


            Console.WriteLine(joueurHaut.Palmares);
            Console.WriteLine(joueurBas.Palmares);

            Console.WriteLine("Vraie partie");
            Partie partieVraie = new Partie(joueurHautHumain, joueurBas, partieInterface, aleatoire);
            partieVraie.Jouer();

            
        }
    }
}


