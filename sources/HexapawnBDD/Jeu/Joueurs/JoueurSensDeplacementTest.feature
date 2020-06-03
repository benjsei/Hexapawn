Feature: Sens de déplacement
	En tant que joueur
	Je veux connaitre mon sens de déplacement
	Afin d'avancer mes pions

#Rule : Règle 1 - Le joueur du bas plateau se déplace vers le haut du plateau.
Scenario: Le joueur du bas se déplace vers le haut
	Given Je suis un joueur en bas du plateau
	When J'avance mon pion
	Then mon pion se déplace vers le haut

#Rule : Règle 2 - Le joueur du haut plateau se déplace vers le bas du plateau.
Scenario: Le joueur du haut se déplace vers le bas
	Given Je suis un joueur en haut du plateau
	When J'avance mon pion
	Then mon pion se déplace vers le bas
