Feature: Mise en place du plateau
En tant que 2 adversaires
Je veux visualiser un plateau de Hexapawn
Afin de pouvoir commencer une partie

#Rule: Règle 1 - Le plateau est de 3 cases sur 3 cases.
#Rule: Règle 2 - Les joueurs ont 3 pions chacun.
#Rule: Règle 3 - Les pions des joueurs sont positionnés en bas en en haut du plateau.
@MiseEnPlaceTest
Scenario: Plateau de départ
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    When ils démarrent une nouvelle partie
    Then ils voient ce plateau RRR___VVV

