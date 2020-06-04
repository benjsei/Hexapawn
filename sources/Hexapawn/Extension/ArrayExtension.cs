using System;
namespace Hexapawn
{
    public static class Extension
    {
        public static object PremierSinonVide(this Array array)
        {
            if (array.Length > 0)
            {
                return array.GetValue(0);
            }
            return null;
        }

        private static readonly string AfficherFormat = "{0} : {1} \n";
        public static string Afficher(this Array array)
        {
            string afficher = "";
            for(int i = 0; i < array.Length; i++)
            {
                afficher += String.Format(AfficherFormat,
                    i,
                    array.GetValue(i).ToString());
            }
            return afficher;
        }
    }

}
