Feature: HomePageRegisterandLogin

As a Lead QA I want to verify home page and all other menu item pages loading fine


Background: Verify ENSEK site load
	Given load the URL
	

Scenario:Verify home page load fine
	Then verfiy the page loads successfully

Scenario:Verify home menus
	Then click the About menu
	And verify about page loading fine
	Then click the contact menu
	And verify contact page loading fine
	Then click the register menu
	And verify register page loading fine
	Then click the login menu
	And verify login page loading fine

