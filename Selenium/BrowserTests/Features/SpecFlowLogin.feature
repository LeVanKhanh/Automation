Feature: SpecFlowLogin
	In order to login
	As a employee
	I want to successfully login to the application

Background:
Given I am logged in as Guest

Scenario: Login success when input correct Name and Password 
	And I input the correct account
	When I click on login
	Then I can access home page

Scenario: Login fail when input incorrect Name and Password 
	And I input the incorrect account
	When I click on login
	Then I go to error page
