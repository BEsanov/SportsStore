using System;
using TechTalk.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SportsStore.Entities;
namespace SportStore.BDDSpecicationTest
{
    [Binding]
    public class ShoppingCartSteps
    {
        ShoppingCart cart = new ShoppingCart();
        public decimal total { get; set; }
        private decimal FirstResult { get; set; }
        private decimal SecondResult { get; set; }
        private decimal ThirdResult { get; set; }

        [Given(@"I have added  (.*) euro (.*) hard disks into Shopping Cart")]
        public void GivenIHaveAddedEuroHardDisksIntoShoppingCart(decimal cost, int quantity)
        {
            cart.NameOfProduct = "hard disk";
            cart.Cost = cost;
            cart.Quantity = quantity;
            FirstResult = cost * quantity;
        }
        
        [Given(@"I have also added  (.*) euro (.*) wireless keyboard into the Shopping Cart")]
        public void GivenIHaveAlsoAddedEuroWirelessKeyboardIntoTheShoppingCart(decimal cost, int quantity)
        {
            cart.NameOfProduct = "Wireless keyboard";
            cart.Cost = cost;
            cart.Quantity = quantity;
            SecondResult = cost * quantity;
        }
        
        [Given(@"I have finally added  (.*) euro (.*) headsets into the Shopping Cart")]
        public void GivenIHaveFinallyAddedEuroHeadsetsIntoTheShoppingCart(decimal cost, int quantity)
        {
            cart.NameOfProduct = "Headset";
            cart.Cost = cost;
            cart.Quantity = quantity;
            ThirdResult = cost * quantity;
        }
        
        [When(@"I press Proceed To Checkout")]
        public decimal WhenIPressProceedToCheckout()
        {
            total= FirstResult + SecondResult + ThirdResult;
            return total;  
        }
        
        [Then(@"the Total value should be (.*) euro on the my shopping summary")]
        public void ThenTheTotalValueShouldBeEuroOnTheMyShoppingSummary(decimal totalValueExpected)
        {
            Assert.AreEqual(totalValueExpected, total);
        }
    }
}
