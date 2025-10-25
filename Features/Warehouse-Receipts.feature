Feature: Warehouse Receipts

@CodeSolversExam
Scenario: Verify the app shows the correct status for all warehouse receipts records
	Given user is logged in with NetworkId "<NetworkId>", Username "<Username>", and Password "<Password>"
	When user navigates to warehouse receipts module
	And user applies OnHand status filter
	Then the app should show records with On Hand status
	And user should be on login screen after logging out

	Examples: 
		| NetworkId | Username | Password    | FilterStatus |
		|     38092 | namnun   | M@g@y@33166 | On Hand      |