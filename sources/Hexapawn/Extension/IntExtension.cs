using System;
namespace Hexapawn
{
    public static class IntExtension
    {
        public const int zeroValue = 0;
        private static readonly int facteurInverse = -1;

        public static int Inverser(this int entier)
        {
            return entier * facteurInverse;
        }

        public static bool DifferentZero(this int entier)
        {
            return entier != zeroValue;
        }

        public static int ZeroValue(this int entier)
        {
            return zeroValue;
        }
    }
}
