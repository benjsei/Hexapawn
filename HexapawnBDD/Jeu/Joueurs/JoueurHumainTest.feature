Feature: Joueur Humain
	En tant que Joueur Humain
	Je veux sélectionner mon déplacement de manière manuelle
	Afin de faire avancer mes pions

#Rule: Régle 1 - Le premier deplacement est choisi manuellement dans une liste de déplacement.
@JoueurHumain
Scenario: Deplacement choisi parmi 3 deplacements 
	Given Je vois ce plateau VVV___RRR
	And J'ai ces deplacements disponibles
	| depart    | fin   |
    | 2:0       | 1:0   |
    | 2:1       | 1:1   |
    | 2:2       | 1:2   |
	When Je choisie un déplacement 1
	Then le déplacement choisi est
	| depart    | fin   |
    | 2:1       | 1:1   |
