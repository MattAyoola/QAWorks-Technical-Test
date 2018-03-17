Feature: ContactUsPage
	As an end user
	I want a contact us page
	So that I can find out more about QAWorks exciting services

# Acceptance Test/ Scenarios
Scenario: Valid Submission
	Given I am on the QAWorks Site
	When I navigate to contact us section
	Then I should be able to contact QAWorks with the following information
	 	 | Name     | Email                | Subject         | Message                                   |
	 	 | j.Bloggs | j.Bloggs@qaworks.com | test automation | please contact me I want to find out more |

