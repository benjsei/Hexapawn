Feature: Generateur de hasard
	En tant que Developpeur
	Je veux obtenir un générateur de hasard
	Afin d'ajouter de l'aléatoire dans les parties

#Rule : Règles 1 - Entier aléatoire compris entre 0 et un maximum
@AleatoireTest
Scenario: Entier inférieur 10
	Given Je veux un entier inférieur à 10
	When Je génére un entier
	Then L'entier est inférieur au maximum
	And L'entier est supérieur à 0

#Rule : Règles 2 - Tirage au sort d'une pièce
Scenario: Tirage pièce
	Given Je veux tirer à pile ou face
	When Je lance la pièce
	Then J'obtiens pile ou face