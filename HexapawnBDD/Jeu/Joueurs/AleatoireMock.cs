using System;
using Hexapawn;

namespace HexapawnBDD.Jeu.Joueurs
{
    public class AleatoireMock: IAleatoire
    {
        public static int ChiffreAleatoireRetour;
        public int ChiffreAleatoire(int max)
        {
            return ChiffreAleatoireRetour;
        }
    }
}
