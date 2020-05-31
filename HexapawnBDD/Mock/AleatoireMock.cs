using System;
using Hexapawn;

namespace HexapawnBDD.Mock
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
