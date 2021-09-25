Feature: Login Admin Page(Table)
	Who: Application administrator
	What: Login to admin page
	Why: To mange application settings
	“As a [persona], I [want to], [so that].”
	As a application administrator, I want to login to admin page, so that I can manage the application settings

Scenario Outline: Authentication successful
	Given Table I have successful authentication with correct account
		| attribute | value |
		| username  | admin |
		| password  | admin |
	When Table trigger login
	Then Table the IsAuthenticated should be true

Scenario Outline:  Authentication failed with incorrect account
	Given Table I have failed authentication with incorrect account
		| attribute | value |
		| username  | admim |
		| password  | admin |
	When Table trigger login
	Then Table the Message should be The username or password is incorrect!

Scenario Outline: Authentication failed with missing input
	Given Table I have failed authentication with missing input
		| attribute | value |
		| username  |       |
		| password  | admin |
	When Table trigger login
	Then Table the Message should be The username and password are requied!