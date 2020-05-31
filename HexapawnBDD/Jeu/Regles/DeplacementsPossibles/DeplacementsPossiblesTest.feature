Feature: Lister les déplacements autorisés
En tant que Joueur
Je veux connaitre les coups autorisés
Afin de pouvoir bouger mon pion dans les régles

#Rule: Règle 1 - Les pions peuvent avancer d'une case si la case est vide.
@DeplacementsPossiblesTest
Scenario: Lister les coups possibles de départ pour le joueur du Bas
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    When ils démarrent une nouvelle partie
    Then Paul peut bouger en
    | depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |

@DeplacementsPossiblesTest
Scenario: Lister les coups possibles de départ pour le joueur du Haut
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    When ils démarrent une nouvelle partie
    Then Thomas peut bouger en
    | depart    | fin   |
    | 0:0       | 1:0   |
    | 0:1       | 1:1   |
    | 0:2       | 1:2   |

#Rule: Règle 2 - Les pions ne peuvent pas avancer d'une case si la case est occupée.
@DeplacementsPossiblesTest
Scenario: Paul est bloqué par un pion de Thomas
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 0:0 à 1:0
    Then Paul peut bouger en
    | depart    | fin   |
    | 2:1       | 1:1   |
    | 2:1       | 1:0   |
    | 2:2       | 1:2   |


#Rule: Règle 3 - Les pions peuvent prendre en diagonale un pion adverse.
@DeplacementsPossiblesTest
Scenario: Paul peut prendre un pion de Thomas
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 0:0 à 1:0
    Then Paul peut bouger en
    | depart    | fin   |
    | 2:1       | 1:1   |
    | 2:1       | 1:0   |
    | 2:2       | 1:2   |