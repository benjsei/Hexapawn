Feature: Déroulement d'une partie
	En tant que joueurs
	Je veux démarrer un partie
	Afin qu'un des joueurs gagne

#Rule : Régle 1 - Les joueurs jouent à tour de rôle
Scenario: Le joueur qui joue en premier gagne en un coup
	Given La partie est prête à commencer
	And Le tirage au sort designe le joueur Thomas pour commencer
	When Un joueur gagne au premier coup
	Then 1 coups ont été joués
	And Le joueur gagnant affiché est Thomas

Scenario: Le joueur qui joue en second gagne en deux coups
	Given La partie est prête à commencer
	And Le tirage au sort designe le joueur Thomas pour commencer
	When Un joueur gagne au second coup
	Then 2 coups ont été joués
	And Le joueur gagnant affiché est Paul

#Rule : Régle 2 - Les joueurs apprennent à la fin de la partie
Scenario: Les joueurs apprennent de leur partie
	Given La partie est prête à commencer
	And Le tirage au sort designe le joueur Thomas pour commencer
	When Un joueur gagne au premier coup
	Then Les joueurs apprennent

