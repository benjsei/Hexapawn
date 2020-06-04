Feature: Choix du deplacement
	En tant que joueur
	Je veux choisir le premier déplacement parmi les déplacements possibles
	Afin de faire avancer mes pions

#Rule : Règle 1 - Le joueur peut choisir toujours le premier déplacement parmi ceux proposés.
@JoueurDeplacementTest
Scenario: Déplacement choisi parmi 3 déplacements 
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurDeplacementTest
Scenario: Déplacement choisi parmi 1 déplacement
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurDeplacementTest
Scenario: Déplacement choisi parmi 0 déplacement
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
	When Je choisie un déplacement 
	Then le déplacement choisi est vide