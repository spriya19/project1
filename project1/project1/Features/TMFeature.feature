Feature: TMFeature
As a Turnup Portal admin
I would like to create Time&Material Record
So I can Manage the Time&Material has created Successfully.

create TM Record

Scenario: Create Time and Material Record with vaild Details
	Given I Logged in TrunupProtal Successfully
	When  I Navigated to GoToTMPage
    And   I Create new Time and Material record
	Then  Time and Material Record has Created Successfully
