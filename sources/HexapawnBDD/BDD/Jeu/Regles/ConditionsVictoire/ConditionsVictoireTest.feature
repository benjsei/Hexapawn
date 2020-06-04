Feature: Conditions de victoire
En tant que joueur
Je veux connaitre les conditions de victoire
Afin de pouvoir gagner une partie

#Rule: Règle 1 - Victoire par conquète, le pion d'un joueur a atteint la dernière ligne.
@ConditionsVictoireTest
Scenario: Thomas gagne par conquète
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau _RRR___VV
    When Thomas bouge son pion de 1:0 à 2:0
    Then Thomas gagne la partie

@ConditionsVictoireTest
Scenario: Paul gagne par conquète
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau _RRV___VV
    When Paul bouge son pion de 1:0 à 0:0
    Then Paul gagne la partie

#Rule: Règle 2 - Victoire par destruction, le pion d'un joueur a pris le dernier pion adverse.
@ConditionsVictoireTest
Scenario: Thomas gagne par destruction
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau RRRV_____
    When Thomas bouge son pion de 0:1 à 1:0
    Then Thomas gagne la partie

#Rule: Règle 3 - Victoire par blocage, le pion du joueur empêche tout mouvement du joueur adverse.
@ConditionsVictoireTest
Scenario: Thomas gagne par blocage
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau RRRV_V_V_
    When Thomas bouge son pion de 0:1 à 1:1
    Then Thomas gagne la partie

@ConditionsVictoireTest
Scenario: Paul gagne par blocage
    Given Le joueur du haut est Thomas, et il joue les pions R
    Given Le joueur du bas est Paul, et il joue les pions V
    Given ils voient ce plateau _R_R_RVVV
    When Paul bouge son pion de 2:1 à 1:1
    Then Paul gagne la partie