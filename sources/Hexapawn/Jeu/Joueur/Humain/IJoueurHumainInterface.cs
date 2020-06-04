using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueurs.Humain
{
    public interface IJoueurHumainInterface
    {
        int DemanderDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles);
    }

}
