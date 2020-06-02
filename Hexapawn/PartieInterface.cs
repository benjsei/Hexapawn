using System;
namespace Hexapawn
{
    public class PartieInterface : IPartieInterface
    {
        public void AfficherGagnant(Joueur gagnant)
        {
            Console.Write("Le gagnant est : " + gagnant.nom + "\n");
        }
    }
}
