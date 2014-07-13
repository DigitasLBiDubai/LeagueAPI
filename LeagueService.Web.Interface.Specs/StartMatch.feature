Feature: StartMatch
	In order to play a fooseball match
	As a cloud service
	I want to create a match

@mytag
Scenario: Creating a match
	Given the match api recieves a post requested with the following parameters
		| UtcStartDateTime    | UtcEndDateTime      |
		| 01/07/2014 20:00:00 | 01/07/2014 22:00:00 |
		| 02/07/2014 20:00:00 | 02/07/2014 22:00:00 |
		| 02/07/2014 20:00:00 | 01/07/2014 22:00:00 |
		|                     | 02/07/2014 22:00:00 |
		| 01/07/2014 20:00:00 |                     |
		|                     |                     |
	When the request is processed
	Then the response parameters should be the following
		| Id | HttpResponseCode |
		| 1  | 201              |
		| 2  | 201              |
		| 0  | 400              |
		| 0  | 400              |
		| 0  | 400              |
		| 0  | 400              |