Feature: BuyEnergy

A short summary of the feature

@tag1
Scenario Outline: Verify successful Energy purchase
	Given I am in Ensek Home page
	When I click Buy energy button
	Then I should be shown with buy energy screen
	And I buy "<EachEnergyType>" quantity <NumberOfUnits>
	And I should be shown with sale confirmed message
	And I should verfiy the confirmation message showing the correct unit ordered and remaining unit
Examples: 
| EachEnergyType | NumberOfUnits | 
| Gas            | 1             | 
| Electricity    | 1             | 
| Oil            | 1             | 

