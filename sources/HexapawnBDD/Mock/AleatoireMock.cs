using Hexapawn.Jeu;

namespace HexapawnBDD
{
    public class AleatoireMock: IAleatoire
    {
        public static int ChiffreAleatoireRetour;
        public int ChiffreAleatoire(int max)
        {
            return ChiffreAleatoireRetour;
        }

        public static bool VraiOuFauxAleatoireRetour;
        public bool VraiOuFauxAleatoire()
        {
            return VraiOuFauxAleatoireRetour;
        }
    }
}
