Feature: En tant que joueur
Je veux visualiser un plateau de Hexapawn
Afin de pouvoir commencer une partie

Scenario: Plateau de départ
    Given Je veux commencer une partie de Hexapawn
    When Je démarre une nouvelle partie
    Then je vois ce plateau 111___222

Scenario: Plateau de départ le joueur avance son premier pion
    Given Je démarre une nouvelle partie
    When Je bouge mon pion de 1:1 à 2:1
    Then je vois ce plateau _111__222

Scenario: Plateau de départ le joueur avance son deuxieme pion
    Given Je démarre une nouvelle partie
    When Je bouge mon pion de 1:2 à 2:2
    Then je vois ce plateau 1_1_1_222

Scenario: Plateau de départ le joueur avance un pion inexistant
    Given Je démarre une nouvelle partie
    When Je bouge mon pion de 2:2 à 2:3
    Then je vois ce plateau 111___222

Scenario: IA liste ses coups possibles
    Given Je démarre une nouvelle partie
    When Je bouge mon pion de 1:2 à 2:2
    Then l'IA peut bouger en
    | depart    | fin   |
    | 3:1       | 2:1   |
    | 3:2       | 2:2   |
    | 3:3       | 2:3   |
    