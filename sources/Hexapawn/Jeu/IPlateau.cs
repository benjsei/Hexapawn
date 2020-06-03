namespace Hexapawn
{
    public interface IPlateau
    {
        bool EstPasTerminee { get; }
        Joueur Gagnant { get; }
        void SelectionnerJoueurActif(bool face);
        void AuJoueurSuivant();
        void Jouer();
        void Enseigner();
    }
}
