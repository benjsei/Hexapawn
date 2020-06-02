Feature: Sens de déplacement
	En tant que joueur
	Je veux connaitre mon sens de déplacement
	Afin d'avancer mes pions
	
Scenario: Le joueur du bas se déplace vers le haut
	Given Je suis un joueur en bas du plateau
	When J'avance mon pion
	Then mon pion se déplace vers le haut

Scenario: Le joueur du haut se déplace vers le bas
	Given Je suis un joueur en haut du plateau
	When J'avance mon pion
	Then mon pion se déplace vers le bas
