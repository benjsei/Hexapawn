Feature: Joueur IA Machine Learning
	En tant que Joueur IA Machine Learning
	Je veux sélectionner mon déplacement de manière optimisée
	Afin de faire avancer mes pions

#Rule: Règle 1 - Le premier déplacement est choisi de manière aléatoire dans une liste de déplacement.
@JoueurIAMachineLearningTest
Scenario: Déplacement choisi parmi 3 déplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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
Scenario: Déplacement choisi parmi 4 déplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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
Scenario: Déplacement choisi parmi 1 déplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
	And l'index tiré aléatoirement est 0
	When Je choisie un déplacement 
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:0       | 1:0   |

#Rule: Règle 2 - En cas d'erreur le déplacement, choisi dans une liste de déplacement, est le premier de la liste.
@JoueurIAMachineLearningTest
Scenario: Index tiré trop grand
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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
@JoueurIAMachineLearningTest
Scenario: Déplacement choisi parmi 0 déplacement
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
	| depart    | fin   |
	And l'index tiré aléatoirement est 10
	When Je choisie un déplacement 
	Then le déplacement choisi est vide

#Rule: Règle 4 - le dernier choix est supprimé en cas de défaite.
@JoueurIAMachineLearningTest
Scenario: 2 déplacements choisis parmi 3 déplacements pour la même situation après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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

#Rule: Règle 5 - le dernier choix n'est pas supprimé en cas de victoire.
@JoueurIAMachineLearningTest
Scenario: 2 déplacements choisis parmi 3 déplacements pour la même situation après une victoire.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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

#Rule: Règle 6 - Le dernier choix n'est pas supprimé en cas de défaite si il n'y a pas d'autres alternatives.
@JoueurIAMachineLearningTest
Scenario: 2 déplacements choisis parmi 1 déplacement pour la même situation après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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

#Rule: Règle 7 - le dernier choix est supprimé que pour une situation.
@JoueurIAMachineLearningTest
Scenario: 2 déplacements choisis parmi 3 déplacements pour une situation différente après une défaite.
	Given Je vois ce plateau VVV___RRR
	And J'ai ces déplacements disponibles
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