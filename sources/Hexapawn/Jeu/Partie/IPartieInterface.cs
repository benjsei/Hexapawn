using System;
using Hexapawn.Jeu.Joueurs;

namespace Hexapawn.Jeu.Partie
{
    public interface IPartieInterface
    {
        void AfficherResultat(Joueurs.Joueur gagnant);
    }
}
