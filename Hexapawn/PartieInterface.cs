using System;
namespace Hexapawn
{
    public class PartieInterface : IPartieInterface
    {
        public void AfficherResultat(Joueur gagnant)
        {
            Console.Write("Le gagnant est : " + gagnant.nom + "\n");
            Console.WriteLine(gagnant.Palmares);            
        }
    }
}
