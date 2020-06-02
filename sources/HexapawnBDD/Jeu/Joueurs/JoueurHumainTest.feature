Feature: Joueur Humain
	En tant que Joueur Humain
	Je veux sélectionner mon déplacement de manière manuelle
	Afin de faire avancer mes pions

#Rule: Régle 1 - Le premier deplacement est choisi manuellement dans une liste de déplacement.
@JoueurHumain
Scenario: Deplacement choisi parmi 3 deplacements 
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 0
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Deplacement choisi parmi 1 deplacement
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	When Je choisie un déplacement 0
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Deplacement choisi n'est pas dans les choix possibles
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 4
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

@JoueurHumain
Scenario: Deplacement choisi parmi 0 deplacement
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
	When Je choisie un déplacement 1
	Then le déplacement choisi est vide