Feature: LogingFeature
	Simple calculator for adding two numbers


Scenario: login with valid credentials
	Given I am on the login page
	When I fill in "Username" with "hari"
	And I fill in "Password" with 123123
	And I press "Login"
	Then I should be on the users home page "TurnUp"
	