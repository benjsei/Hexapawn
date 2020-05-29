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
    }

}
