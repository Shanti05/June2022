Feature: TMFeature

A short summary of theAs a turnup portal admin
I would like to create, edit and delete time and material records
So that I can manage employees time and material records successfully
 feature

@myTag
Scenario: 1 Create material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to time and material page 
	When I create a new material record
	Then The record should be created successfully

@yourTag
	Scenario Outline:2 Edit material record with valid details
Given I logged into turnup portal successfully
When I navigate to time and material page
When I update '<Code> ','<Description>','<Price>' of existing material record
Then The record should have the '<Code>','<Description>','<Price>' updated

Examples: 

| Code    | Description | Price    |
| Keyboard| Black       | $700.00  |
| Violin  | Brown       | $600.00  |
| Guitar  | White       | $900.00  |

Scenario:3 Delete material record with valid details
Given  I logged into turnup portal successfully
When  I navigate to time and material page 
When  I deleted an existing time and material record 
Then The record deleted successfully