Feature: StartMatch
	In order to play a fooseball match
	As a cloud service
	I want to create a match

@mytag
Scenario: Creating a match
	Given I want to start playing a new match 
	When I am passed the start date of the match by the fooseball table
	Then <MatchId> is created
	And <StartDate> is assigned to the match

	| MatchId | StartDate  |
	| 1       | 01/07/2014 |
	| 2       | 02/07/2014 |