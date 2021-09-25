Feature: Login Admin Page(BasicSetting)
	Who: Application administrator
	What: Login to admin page
	Why: To mange application settings
	“As a [persona], I [want to], [so that].”
	As a application administrator, I want to login to admin page, so that I can manage the application settings

Scenario: Input the right usename and password with account admin
	Given BasicSetting the username is admin
	And BasicSetting the password is admin
	When BasicSetting trigger login
	Then BasicSetting the IsAuthenticated should be true

Scenario: Input the right usename and password with account administrator
	Given BasicSetting the username is administrator
	And BasicSetting the password is administrator
	When BasicSetting trigger login
	Then BasicSetting the IsAuthenticated should be true

Scenario: Input the right usename and password with account superadmin
	Given BasicSetting the username is superadmin
	And BasicSetting the password is superadmin
	When BasicSetting trigger login
	Then BasicSetting the IsAuthenticated should be true

Scenario: Input the right usename and password with account superadministrator
	Given BasicSetting the username is superadministrator
	And BasicSetting the password is superadministrator
	When BasicSetting trigger login
	Then BasicSetting the IsAuthenticated should be true

Scenario: The username is empty
	Given BasicSetting the username is null
	And BasicSetting the password is admin
	When BasicSetting trigger login
	Then BasicSetting the Message should be The username and password are requied!

Scenario: The password is empty
	Given BasicSetting the username is admin
	And BasicSetting the password is null
	When BasicSetting trigger login
	Then BasicSetting the Message should be The username and password are requied!

Scenario: The username is wrong
	Given BasicSetting the username is admim
	And BasicSetting the password is admin
	When BasicSetting trigger login
	Then BasicSetting the Message should be The username or password is incorrect!

Scenario: The password is wrong
	Given BasicSetting the username is admin
	And BasicSetting the password is admim
	When BasicSetting trigger login
	Then BasicSetting the Message should be The username or password is incorrect!
