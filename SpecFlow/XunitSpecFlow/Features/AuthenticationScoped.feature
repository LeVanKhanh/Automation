﻿Feature: Login Admin Page(Scoped)
	Who: Application administrator
	What: Login to admin page
	Why: To mange application settings
	“As a [persona], I [want to], [so that].”
	As a application administrator, I want to login to admin page, so that I can manage the application settings

Background:
	Given I access the authentication page

@AuthenticationSuccessful
Scenario Outline: Authentication successful
	And Scoped the username is <username>
	And Scoped the password is <password>
	When Scoped trigger login
	Then Scoped the IsAuthenticated should be true

	Examples:
		| username           | password           |
		| admin              | admin              |
		| administrator      | administrator      |
		| superadmin         | superadmin         |
		| superadministrator | superadministrator |

@AuthenticationFailed
Scenario Outline: Authentication failed
	And Scoped the username is <username>
	And Scoped the password is <password>
	When Scoped trigger login
	Then Scoped the Message should be <message>

	Examples:
		| username     | password     | message                                |
		| ToNullString | admin        | The username and password are requied! |
		| admin        | ToNullString | The username and password are requied! |
		|              | admin        | The username and password are requied! |
		| admin        |              | The username and password are requied! |
		| admim        | admin        | The username or password is incorrect! |
		| admin        | admim        | The username or password is incorrect! |