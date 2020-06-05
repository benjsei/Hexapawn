namespace Hexapawn.Jeu.Plateau
{
    public static class Cases
    {
        private const int zeroValue = 0;
        private const string caseVide = "_";
        private const int dimensionLigne = 0;
        private const int dimensionColonne = 1;

        public static bool Contient(this string[,] cases, string pion, Position position)
        {
            return cases[position.Ligne, position.Colonne] == pion;
        }

        public static bool EstVide(this string[,] cases, Position position)
        {
            return cases[position.Ligne, position.Colonne] == caseVide;
        }

        public static bool ContientPas(this string[,] cases, string pion, Position position)
        {
            return cases[position.Ligne, position.Colonne] != pion;
        }

        public static bool EstPasVide(this string[,] cases, Position position)
        {
            return !cases.EstVide(position);
        }

        public static void Affecter(this string[,] cases, string pion, Position position)
        {
            cases[position.Ligne, position.Colonne] = pion;
        }

        public static void Vider(this string[,] cases, Position position)
        {
            cases[position.Ligne, position.Colonne] = caseVide;
        }

        private static void ViderColonne(this string[,] cases, int ligne)
        {
            for (int colonne = 0; colonne < cases.NombreColonnes(); colonne++)
            {
                cases[ligne, colonne] = caseVide;
            }
        }

        public static bool ContientAutre(this string[,] cases, string pion, Position position)
        {
            return position.Colonne >= zeroValue &&
                position.Colonne < cases.NombreColonnes() &&
                cases.EstPasVide(position) &&
                cases.ContientPas(pion, position);
        }

        public static int NombreLignes(this string[,] cases)
        {
            return cases.GetLength(dimensionLigne);
        }

        public static int NombreColonnes(this string[,] cases)
        {
            return cases.GetLength(dimensionColonne);
        }

        public static void Vider(this string[,] cases)
        {
            for (int ligne = 0; ligne < cases.NombreLignes(); ligne++)
            {
                cases.ViderColonne(ligne);
            }
        }

        public static void Restaurer(this string[,] cases, string damier)
        {
            for (int i = 0; i < cases.NombreCases(); i++)
            {
                int ligne = i / cases.NombreColonnes();
                int colonne = i - cases.NombreColonnes() * ligne;
                cases[ligne, colonne] = damier[i].ToString();
            }
        }

        public static string Afficher(this string[,] cases)
        {
            var affichage = string.Empty;
            for (int ligne = 0; ligne < cases.NombreLignes(); ligne++)
            {
                affichage += cases.Afficher(ligne);
            }

            return affichage;
        }

        private static string Afficher(this string[,] cases, int ligne)
        {
            var affichageColonne = string.Empty;
            for (int colonne = 0; colonne < cases.NombreColonnes(); colonne++)
            {
                affichageColonne += cases[ligne, colonne];
            }

            return affichageColonne;
        }

        private static int NombreCases(this string[,] cases)
        {
            return cases.NombreLignes() * cases.NombreColonnes();
        }
    }
}
