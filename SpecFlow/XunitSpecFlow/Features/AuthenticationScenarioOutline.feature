Feature: Login Admin Page(ScenarioOutline)
	Who: Application administrator
	What: Login to admin page
	Why: To mange application settings
	“As a [persona], I [want to], [so that].”
	As a application administrator, I want to login to admin page, so that I can manage the application settings

Scenario Outline: Authentication successful
	Given ScenarioOutline the username is <username>
	And ScenarioOutline the password is <password>
	When ScenarioOutline trigger login
	Then ScenarioOutline the IsAuthenticated should be true

	Examples:
		| username           | password           |
		| admin              | admin              |
		| administrator      | administrator      |
		| superadmin         | superadmin         |
		| superadministrator | superadministrator |

Scenario Outline: Authentication failed
	Given ScenarioOutline the username is <username>
	And ScenarioOutline the password is <password>
	When ScenarioOutline trigger login
	Then ScenarioOutline the Message should be <message>

	Examples:
		| username     | password     | message                                |
		| ToNullString | admin        | The username and password are requied! |
		| admin        | ToNullString | The username and password are requied! |
		|              | admin        | The username and password are requied! |
		| admin        |              | The username and password are requied! |
		| admim        | admin        | The username or password is incorrect! |
		| admin        | admim        | The username or password is incorrect! |