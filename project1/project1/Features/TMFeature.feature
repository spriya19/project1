Feature: TMFeature
As a Turnup Portal admin
I would like to create, Edit and Delete the Time&Material Record
So I can Manage the Employees Time&Material has created, Edited and Deleted Successfully.

TM Record create,Edit and Delete
Scenario: Create Time and Material Record with vaild Details	
	Given I Logged in TrunupProtal Successfully
	When  I Navigated to GoToTMPage
	When  I Create new Time and Material record
	Then   The Record has created successfully
