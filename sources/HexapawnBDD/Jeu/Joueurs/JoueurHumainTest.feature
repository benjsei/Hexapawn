Feature: Joueur Humain
	En tant que Joueur Humain
	Je veux sélectionner mon déplacement de manière manuelle
	Afin de faire avancer mes pions

#Rule: Règle 1 - Le premier déplacement est choisi manuellement dans une liste de déplacement.
@JoueurHumain
Scenario: Déplacement choisi parmi 3 déplacements 
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 0
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Déplacement choisi parmi 1 déplacement
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	When Je choisie un déplacement 0
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Déplacement choisi n'est pas dans les choix possibles
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 4
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Déplacement choisi parmi 0 déplacement
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
	When Je choisie un déplacement 1
	Then le déplacement choisi est vide