using System;

namespace Hexapawn
{
    public class JoueurHumainInterface : IJoueurHumainInterface
    {
        public int DemanderDeplacement(Plateau plateau, Deplacement[] deplacementsPossibles)
        {
            string lisible = plateau.Afficher();
            lisible = lisible.Insert(6, "\n");
            lisible = lisible.Insert(3, "\n");

            Console.WriteLine("Plateau : ");
            Console.WriteLine(lisible);
            Console.WriteLine("Les choix possibles : ");
            Console.WriteLine(deplacementsPossibles.Afficher());
            Console.WriteLine("Quel est votre choix ?");

            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
