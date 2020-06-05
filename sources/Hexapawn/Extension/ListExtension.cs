using System;
using System.Collections.Generic;

namespace Hexapawn
{
    public static class Extension
    {
        private static readonly int seuilAuMoinsDeux = 2;
        private static readonly int premierIndex = 0;

        public static bool AAuMoinsDeux<T>(this List<T> list)
        {
            return list.Count >= seuilAuMoinsDeux;
        }

        public static T Premier<T>(this List<T> list)
        {
            if (list.Count > 0)
            {
                return list[premierIndex];
            }

            return default;
        }
    }
}
