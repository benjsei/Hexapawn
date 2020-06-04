Feature: Joueur Aléatoire
	En tant que Joueur Aléatoire
	Je veux sélectionner mon déplacement aléatoirement
	Afin de faire avancer mes pions

#Rule: Règle 1 - Le déplacement est choisi de manière aléatoire dans une liste de déplacement.
@JoueurAleatoireTest
Scenario: Déplacement choisi parmi 3 déplacements 
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 1
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |

@JoueurAleatoireTest
Scenario: Déplacement choisi parmi 4 déplacements 
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	| 0:0       | 1:1   |
	And l'index tiré aléatoirement est 2
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:2       | 1:2   |

@JoueurAleatoireTest
Scenario: Déplacement choisi parmi 1 déplacements 
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	And l'index tiré aléatoirement est 0
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Règle 2 - En cas d'erreur le déplacement, choisi dans une liste de déplacement, est le premier de la liste.
@JoueurAleatoireTest
Scenario: Index tiré trop grand
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Règle 3 - Le déplacement choisi retourné pour une liste de déplacement sans élément est vide.
@JoueurAleatoireTest
Scenario: Déplacement choisi parmi 0 déplacement
	Given J'ai ces déplacements disponibles
	| depart    | fin   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est vide