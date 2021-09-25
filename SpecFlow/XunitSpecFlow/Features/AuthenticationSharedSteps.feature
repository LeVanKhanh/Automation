Feature: Login Admin Page(SharedSteps)
	Who: Application administrator
	What: Login to admin page
	Why: To mange application settings
	“As a [persona], I [want to], [so that].”
	As a application administrator, I want to login to admin page, so that I can manage the application settings

Scenario: Input the right usename and password with account admin
	Given SharedSteps the username is admin
	And SharedSteps the password is admin
	When SharedSteps trigger login
	Then SharedSteps the IsAuthenticated should be true

Scenario: Input the right usename and password with account administrator
	Given SharedSteps the username is administrator
	And SharedSteps the password is administrator
	When SharedSteps trigger login
	Then SharedSteps the IsAuthenticated should be true

Scenario: Input the right usename and password with account superadmin
	Given SharedSteps the username is superadmin
	And SharedSteps the password is superadmin
	When SharedSteps trigger login
	Then SharedSteps the IsAuthenticated should be true

Scenario: Input the right usename and password with account superadministrator
	Given SharedSteps the username is superadministrator
	And SharedSteps the password is superadministrator
	When SharedSteps trigger login
	Then SharedSteps the IsAuthenticated should be true

Scenario: The username is empty
	Given SharedSteps the username is null
	And SharedSteps the password is admin
	When SharedSteps trigger login
	Then SharedSteps the Message should be The username and password are requied!

Scenario: The password is empty
	Given SharedSteps the username is admin
	And SharedSteps the password is null
	When SharedSteps trigger login
	Then SharedSteps the Message should be The username and password are requied!

Scenario: The username is wrong
	Given SharedSteps the username is admim
	And SharedSteps the password is admin
	When SharedSteps trigger login
	Then SharedSteps the Message should be The username or password is incorrect!

Scenario: The password is wrong
	Given SharedSteps the username is admin
	And SharedSteps the password is admim
	When SharedSteps trigger login
	Then SharedSteps the Message should be The username or password is incorrect!
