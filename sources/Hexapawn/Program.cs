using System;
using Hexapawn.Jeu;
using Hexapawn.Jeu.Joueur;
using Hexapawn.Jeu.Joueur.Humain;
using Hexapawn.Jeu.Partie;
using Hexapawn.Jeu.Plateau;

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

            Console.WriteLine("HexaPawn : Apprentissage IA");


            for (int i = 0; i < 1000; i++) {
                IPlateau plateau = new Plateau(joueurHaut, joueurBas);
                Partie partie = new Partie(plateau, partieInterface, aleatoire);
                partie.Jouer();
            }

            Console.WriteLine("HexaPawn : Apprentissage IA Terminée");

            Console.WriteLine("HexaPawn : Jeu ");

            bool voulezVousContinuer = true;

            while(voulezVousContinuer)
            {
                IPlateau plateauVrai = new Plateau(joueurHautHumain, joueurBas);
                Partie partieVraie = new Partie(plateauVrai, partieInterface, aleatoire);
                partieVraie.Jouer();

                Console.WriteLine("Voulez-vous rejouer ? (O/N)");
                voulezVousContinuer = Console.ReadLine().ToUpper() == "O";
            }

            Console.WriteLine("HexaPawn : Jeu Terminé");

        }
    }
}


