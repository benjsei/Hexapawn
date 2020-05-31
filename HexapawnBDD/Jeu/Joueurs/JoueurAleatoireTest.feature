Feature: Joueur Aléatoire
	En tant que Joueur Aléatoire
	Je veux sélectionner mon déplacement aléatoirement
	Afin de faire avancer mes pions

#Rule: Régle 1 - Le deplacement est choisi de maniere aléatoire dans une liste de déplacement.
@JoueurAleatoireTest
Scenario: Deplacement choisi parmi 3 deplacements 
	Given J'ai ces deplacements disponibles
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
Scenario: Deplacement choisi parmi 4 deplacements 
	Given J'ai ces deplacements disponibles
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
Scenario: Deplacement choisi parmi 1 deplacements 
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	And l'index tiré aléatoirement est 0
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Régle 2 - En cas d'erreur Le deplacement, choisi dans une liste de déplacement, est le premier de la liste.
@JoueurAleatoireTest
Scenario: Index tiré trop grand
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Régle 3 - Le deplacement choisi retourné pour une liste de déplacement sans élement est vide.
@JoueurAleatoireTest
Scenario: Deplacement choisi parmi 0 deplacement
	Given J'ai ces deplacements disponibles
	| depart    | fin   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est vide