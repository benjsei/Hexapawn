using System;


namespace Hexapawn
{
    class MainClass
    {

        public static void Main(string[] args)
        {
            IAleatoire aleatoire = new Aleatoire();
            IJoueurHumainInterface joueurHumainInterface = new JoueurHumainInterface();
            IPartieInterface partieInterface = new PartieInterface();

            Joueur joueurHaut = new JoueurAleatoire("ThomasCoupDeChance", "R", aleatoire);
            Joueur joueurBas = new JoueurIAMachineLearning("PaulLIntello", "V", aleatoire);
            Joueur joueurHautHumain = new JoueurHumain("Moi", "R", joueurHumainInterface);

            Console.WriteLine("Hello World!");


            for (int i = 0; i < 1000; i++) {
                IPlateau plateau = new Plateau(joueurHaut, joueurBas);
                Partie partie = new Partie(plateau, partieInterface, aleatoire);
                partie.Jouer();
            }

            Console.WriteLine("Terminée");

            Console.WriteLine("Vraie partie");

            IPlateau plateauVrai = new Plateau(joueurHautHumain, joueurBas);
            Partie partieVraie = new Partie(plateauVrai, partieInterface, aleatoire);
            partieVraie.Jouer();
        }
    }
}


