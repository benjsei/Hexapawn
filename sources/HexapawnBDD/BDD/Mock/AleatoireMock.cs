using Hexapawn.Jeu;

namespace HexapawnBDD
{
    public class AleatoireMock: IAleatoire
    {
        public static int ChiffreAleatoireRetour;
        public int RecupererEntier(int max)
        {
            return ChiffreAleatoireRetour;
        }

        public static bool VraiOuFauxAleatoireRetour;
        public bool RecupererVraiOuFaux()
        {
            return VraiOuFauxAleatoireRetour;
        }
    }
}
