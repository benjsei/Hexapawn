using Hexapawn.Jeu.Plateau;

namespace Hexapawn.Jeu.Joueur.Humain
{
    public interface IJoueurHumainInterface
    {
        int DemanderDeplacement(IPlateau plateau, Deplacement[] deplacementsPossibles);
    }

}
