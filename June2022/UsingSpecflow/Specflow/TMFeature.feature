Feature: TMFeature

As a turnup portal admin
I would like to create, edit and delete time and material records
So that I can manage employees time and material records successfully


Scenario: Create material record with valid details
	Given I logged into turnup portal successfully
	When I navigate to time and material page 
	When I create a new material record
	Then The record should be created successfully

Scenario Outline: 
