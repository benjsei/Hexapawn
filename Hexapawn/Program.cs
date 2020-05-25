using System;

namespace Hexapawn
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Plateau plateau = new Plateau();
            plateau.Afficher();
            Console.WriteLine("Plateau : "+plateau.Afficher());

        }
    }
}
