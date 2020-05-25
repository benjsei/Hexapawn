Feature: En tant que joueur
Je veux visualiser un plateau de Hexapawn
Afin de pouvoir commencer une partie

Scenario: Plateau de départ
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    When ils démarrent une nouvelle partie
    Then ils voient ce plateau RRR___VVV

Scenario: Plateau de départ le joueur avance son premier pion
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 0:0 à 1:0
    Then ils voient ce plateau _RRR__VVV

Scenario: Plateau de départ le joueur avance son deuxieme pion
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 0:1 à 1:1
    Then ils voient ce plateau R_R_R_VVV

Scenario: Plateau de départ le joueur avance un pion inexistant
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 1:1 à 1:2
    Then ils voient ce plateau RRR___VVV

Scenario: Lister les coups possibles de départ pour le joueur du Bas
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When ils démarrent une nouvelle partie
    Then Paul peut bouger en
    | depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |

Scenario: Lister les coups possibles de départ pour le joueur du Haut
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When ils démarrent une nouvelle partie
    Then Thomas peut bouger en
    | depart    | fin   |
    | 0:0       | 1:0   |
    | 0:1       | 1:1   |
    | 0:2       | 1:2   |

Scenario: Paul est bloqué par un pion de Thomas, mais peut le prendre
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils démarrent une nouvelle partie
    When Thomas bouge son pion de 0:0 à 1:0
    Then Paul peut bouger en
    | depart    | fin   |
    | 2:1       | 1:1   |
    | 2:1       | 1:0   |
    | 2:2       | 1:2   |

Scenario: Thomas gagne par conquète
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau _RRR___VV
    When Thomas bouge son pion de 1:0 à 2:0
    Then Thomas gagne la partie

Scenario: Paul gagne par conquète
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau _RRV___VV
    When Paul bouge son pion de 2:0 à 1:0
    Then Paul gagne la partie

Scenario: Thomas gagne par détruction
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau RRRV_____
    When Thomas bouge son pion de 0:1 à 1:0
    Then Thomas gagne la partie