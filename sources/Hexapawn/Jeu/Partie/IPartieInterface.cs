using System;
using Hexapawn.Jeu.Joueur;

namespace Hexapawn.Jeu.Partie
{
    public interface IPartieInterface
    {
        void AfficherResultat(Joueur.Joueur gagnant);
    }
}
