using System;
using Hexapawn;

namespace HexapawnBDD.Mock
{
    public class JoueurHumainInterfaceMock : IJoueurHumainInterface
    {
        public JoueurHumainInterfaceMock()
        {
        }

        public static int DemanderDeplacementRetour;
        public int DemanderDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
        {
            return DemanderDeplacementRetour;
        }
    }
}
