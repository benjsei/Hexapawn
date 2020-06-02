Feature: Palmares
	En tant que Joueur
	Je veux voir mon palmarès
	Afin de comparer mon palmarès aux autres joueurs
	
Scenario: 3 parties dont 1 gagnante
	Given Je suis Paul et je joue les pions V
	And Je fais 1 partie(s) gagnante(s)
	And Je fais 2 partie(s) perdante(s)
	When J'affiche mon palamès
	Then je vois Paul : 1 Victoire(s) pour 3 Combat(s) (33.33%).

Scenario: 3 parties dont 3 gagnantes
	Given Je suis Paul et je joue les pions V
	And Je fais 3 partie(s) gagnante(s)
	When J'affiche mon palamès
	Then je vois Paul : 3 Victoire(s) pour 3 Combat(s) (100.00%).

Scenario: 1 partie dont 1 gagnante
	Given Je suis Paul et je joue les pions V
	And Je fais 1 partie(s) gagnante(s)
	When J'affiche mon palamès
	Then je vois Paul : 1 Victoire(s) pour 1 Combat(s) (100.00%).

Scenario: 1 partie dont 1 perdante
	Given Je suis Paul et je joue les pions V
	And Je fais 1 partie(s) perdante(s)
	When J'affiche mon palamès
	Then je vois Paul : 0 Victoire(s) pour 1 Combat(s) (0.00%).

Scenario: 0 partie
	Given Je suis Paul et je joue les pions V
	And Je fais 0 partie(s) gagnante(s)
	When J'affiche mon palamès
	Then je vois Paul : 0 Victoire(s) pour 0 Combat(s) (0.00%).