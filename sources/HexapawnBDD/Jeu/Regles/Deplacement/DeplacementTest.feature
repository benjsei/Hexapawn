    Feature: Déplacement des pions
    En tant que Joueur
    Je veux déplacer mes pions
    Afin de progresser dans la partie

    #Rule: Règle 1 - Le déplacement d'un pion est visible sur le plateau.
    @DeplacementTest
    Scenario: Plateau de départ le joueur avance son premier pion
        Given Le joueur du haut est Thomas, et il joue les pions R
        Given Le joueur du bas est Paul, et il joue les pions V
        Given ils démarrent une nouvelle partie
        When Thomas bouge son pion de 0:0 à 1:0
        Then ils voient ce plateau _RRR__VVV

    @DeplacementTest
    Scenario: Plateau de départ le joueur avance son deuxieme pion
        Given Le joueur du haut est Thomas, et il joue les pions R
        Given Le joueur du bas est Paul, et il joue les pions V
        Given ils démarrent une nouvelle partie
        When Thomas bouge son pion de 0:1 à 1:1
        Then ils voient ce plateau R_R_R_VVV

    #Rule: Règle 2 - Le déplacement d'une case vide n'est pas pris en compte.
    @DeplacementTest
    Scenario: Le joueur avance un pion inexistant
        Given Le joueur du haut est Thomas, et il joue les pions R
        Given Le joueur du bas est Paul, et il joue les pions V
        Given ils démarrent une nouvelle partie
        When Thomas bouge son pion de 1:1 à 1:2
        Then ils voient ce plateau RRR___VVV

    #Rule: Règle 3 - Le déplacement d'un pion sur un pion adverse est une prise.
    @DeplacementTest
    Scenario: Le joueur se deplace sur un pion adverse
        Given Le joueur du haut est Thomas, et il joue les pions R
        Given Le joueur du bas est Paul, et il joue les pions V
        Given ils démarrent une nouvelle partie
        When Thomas bouge son pion de 0:1 à 2:1
        Then ils voient ce plateau R_R___VRV

    #Rule: Règle 4 - Le déplacement d'un pion sur un pion du même joueur n'est pas pris en compte.
    @DeplacementTest
    Scenario: Le joueur se deplace sur un de ses pions
        Given Le joueur du haut est Thomas, et il joue les pions R
        Given Le joueur du bas est Paul, et il joue les pions V
        Given ils démarrent une nouvelle partie
        When Thomas bouge son pion de 0:1 à 0:2
        Then ils voient ce plateau RRR___VVV