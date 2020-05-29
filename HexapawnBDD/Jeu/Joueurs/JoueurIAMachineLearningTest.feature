Feature: Joueur IA Machine Learning
	En tant que Joueur IA Machine Learning
	Je veux sélectionner mon déplacement de manière optimisée
	Afin de faire avancer mes pions

#Rule: Régle 1 - Le premier deplacement est choisi de maniere aléatoire dans une liste de déplacement.
@JoueurIAMachineLearningTest
Scenario: Deplacement choisi parmi 3 deplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 1
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |

@JoueurIAMachineLearningTest
Scenario: Deplacement choisi parmi 4 deplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
    | 0:0       | 1:2   |
	And l'index tiré aléatoirement est 2
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:2       | 1:2   |

@JoueurIAMachineLearningTest
Scenario: Deplacement choisi parmi 1 deplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	And l'index tiré aléatoirement est 0
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Régle 2 - En cas d'erreur Le deplacement, choisi dans une liste de déplacement, est le premier de la liste.
@JoueurIAMachineLearningTest
Scenario: Index tiré trop grand
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
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
@JoueurIAMachineLearningTest
Scenario: Deplacement choisi parmi 0 deplacement
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est vide

#Rule: Régle 4 - le dernier choix est supprimé en cas de défaite.
@JoueurIAMachineLearningTest
Scenario: 2 deplacements choisis parmi 3 deplacements pour la même situation après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 1
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |
	And Je perd la partie
	And Je vois ce plateau VVV___RRR
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:2       | 1:2   |

#Rule: Régle 5 - le dernier choix n'est pas supprimé en cas de victoire.
@JoueurIAMachineLearningTest
Scenario: 2 deplacements choisis parmi 3 deplacements pour la même situation après une victoire.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 1
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |
	And Je gagne la partie
	And Je vois ce plateau VVV___RRR
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |

#Rule: Régle 6 - Le dernier choix n'est pas supprimé en cas de défaite si il n'y a pas d'autres altérnatives.
@JoueurIAMachineLearningTest
Scenario: 2 deplacements choisis parmi 1 deplacement pour la même situation après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	And l'index tiré aléatoirement est 0
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |
	And Je gagne la partie
	And Je vois ce plateau VVV___RRR
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Régle 7 - le dernier choix est supprimé que pour une situation.
@JoueurIAMachineLearningTest
Scenario: 2 deplacements choisis parmi 3 deplacements pour une situation différente après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	And l'index tiré aléatoirement est 1
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |
	And Je perd la partie
	And Je vois ce plateau V_V_V_RRR
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |