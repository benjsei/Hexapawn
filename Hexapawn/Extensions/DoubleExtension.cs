using System;
namespace Hexapawn
{
    public static class DoubleExtension
    {
        private static readonly double surCent = 100;

        public static double PourCent(this double decimale)
        {
            return decimale * surCent;
        }
    }
}
