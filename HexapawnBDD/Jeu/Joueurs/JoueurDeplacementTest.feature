Feature: Choix du deplacement
	En tant que joueur
	Je veux choisir le premier déplacement parmi les déplacements possibles
	Afin de faire avancer mes pions

@JoueurDeplacementTest
Scenario: Deplacement choisi parmis 3 deplacements 
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurDeplacementTest
Scenario: Deplacement choisi parmis 1 deplacement
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurDeplacementTest
Scenario: Deplacement choisi parmis 0 deplacement
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
	When Je choisie un déplacement 
	Then le déplacement choisi est vide