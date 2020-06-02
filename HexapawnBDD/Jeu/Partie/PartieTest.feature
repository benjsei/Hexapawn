Feature: Déroulement d'une partie
	En tant que joueurs
	Je veux démarrer un partie
	Afin qu'un des joueurs gagne
	
Scenario: Le joueur qui joue en premier gagne en un coup
	Given La partie est prête à commencer
	And Le tirage au sort designe le joueur Thomas pour commencer
	When Un joueur gagne au premier coup
	Then Le joueur gagnant affiché est Thomas
	And Les joueurs apprennent

Scenario: Le joueur qui joue en second gagne en un coup
	Given La partie est prête à commencer
	And Le tirage au sort designe le joueur Thomas pour commencer
	When Un joueur gagne au second coup
	Then Le joueur gagnant affiché est Paul
	Then 2 coups ont été joués
	And Les joueurs apprennent