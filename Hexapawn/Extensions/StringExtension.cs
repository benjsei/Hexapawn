using System;
namespace Hexapawn
{
    public static class StringExtension
    {
        private static readonly char empty = ' ';

        public static char firstChar(this String str)
        {
            if (str.ToCharArray().GetLength(0) > 0)
            {
                return str.ToCharArray()[0];
            }

            return empty;
        }
    }
}
