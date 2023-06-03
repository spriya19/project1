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
	
	
	
Scenario Outline: Edit Existing time and material record with vaild details
            Given I Logged in TrunupProtal Successfully
            When  I Navigated to GoToTMPage
			And   I update '<Code>', '<Description>' and '<Price>' an Existing Time and material record
			Then  The record should be updated '<Code>','<Description>' and '<Price>'
Examples:
	| Code  | Description | Price     |
	| March | Television  | $800.00   |
	| April | Keyboard    | $200.00   |
	| May   | Remote      | $85.00    |

Scenario Outline: Delete Existing time and material record with vaild details
            Given I Logged in TrunupProtal Successfully
            When  I Navigated to GoToTMPage
			And   I delete '<Code>','<Description>' and'<Price>' an Existing Time and Material record
			Then  The Record should be deleted '<Code>','<Description>',and '<Price>'

Examples:
	| Code  | Description | Price   |
	| March | Television  | $800.00 |

