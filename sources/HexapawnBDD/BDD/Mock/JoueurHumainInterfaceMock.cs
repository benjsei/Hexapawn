using Hexapawn.Jeu.Joueur.Humain;
using Hexapawn.Jeu.Plateau;

namespace HexapawnBDD
{
    public class JoueurHumainInterfaceMock : IJoueurHumainInterface
    {
        public JoueurHumainInterfaceMock()
        {
        }

        public static int DemanderDeplacementRetour;
        public int DemanderDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles)
        {
            return DemanderDeplacementRetour;
        }
    }
}
