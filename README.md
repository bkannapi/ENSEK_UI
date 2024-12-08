ENSEK UI Automation
-------------------------------------------------

1)Technology Used:-
	C#,
	Selenium
	SpecLlow
	PageObjectModel
	GerkinLanguage to write the scenario

2)IDE Used to develop the code-Visualstudio professional 2022(we can use Visual studio free version too)

Instruction to load and run the project:-
------------------------------------------

1)Clone the repository in local

https://github.com/bkannapi/ENSEK_UI

2) Open the ENSEK_UI folder from local and run Ensek.sln file in visual studio

3)Go to Tools and Nugetpackagemanger in visulstudio and install dependencies
	SeleniumWebDriver
	SeleniumWaitHelpers
	SpecflowNunit
	ChromeDriver
	Microsoft.Extensions.Configuration
	Microsoft.Extensions.Configuration.Binder
	Microsoft.Extensions.Configuration_Json
	Microsoft.NET.Test.Sdk
	NUnit
	NUnit3TestAdapter
	SpecFlow.Plus.LivingDocPlugin

4)Rebuild the code to auto install relevant dependencies if not alread

5) The URL not been hardcoded and read from the config file
	Support-Appsettings.Environments.json
	Configuration-EnvironmentConfig.cs
	ReadConfig.cs

6)NUnit Hooks been used
	Hooks  been used to manage the chrome webdriver kept open for BeforeTestRun
	Hooks been used to manage the chrome webdriver closed AfterTestRun
	Multibrowesr run capability also been used in Hooks

7)Features Folder
	HomePageMenu.feature
	IbuySomeEnergy.feature

8)Pages Folder
	
	HomePageMenu.cs
	IbuySomeEnergypage.cs
	
These two class files been used across all stepdefinitions file to ensure code reusability and estabilisy page object model implementation

9)StepDefinitions Folder
	
	HomePageMenustepdefinitions.cs
	IbuySomeEnergystepdefinitions.cs
	
10) Code reusability, page object model, webdriverwait so the releavnt action on the webelement will wait until ensure element load, 
assert statement for vefification and validation been used in this automation framework

11)RUN the code
	Select Test-Test Explorer and select 'Run all tests in view'
you can see all five test run in sequence and PASS, expand the result in test explorer for review.

	
	
	
	


