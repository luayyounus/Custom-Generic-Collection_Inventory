using System;
using EcommerceStore.Classes;
using Xunit;

namespace XUnitTestEcommerceStore
{
    public class UnitTest1
    {
        [Fact]
        public void Return_Equal_Inventory_Count_When_Adding()
        {
            // Arrange
            Product product = new Product("Computer", ProductType.Home);
            Inventory<Product> inventory = new Inventory<Product>();

            // Act
            inventory.Add(product);

            // Assert
            Assert.Equal(1, inventory.Count);
        }
    }
}
