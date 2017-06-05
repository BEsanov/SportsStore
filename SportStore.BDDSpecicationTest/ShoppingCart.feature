Feature: ShoppingCart
@mytag
	Scenario: Calculating Products total values
	Given I have added  120 euro 3 hard disks into Shopping Cart
	And I have also added  30 euro 1 wireless keyboard into the Shopping Cart
	And I have finally added  10 euro 2 headsets into the Shopping Cart
	When I press Proceed To Checkout
	Then the Total value should be 410 euro on the my shopping summary
