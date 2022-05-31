// To create xunit tests, run: dotnet new xunit -n Tests  
// Once created, run: dotnet add package xUnit  
using Xunit;
using Models;
using CustomExceptions;
using System.Collections.Generic;

namespace Tests;
// To run test, type `dotnet test`.
public class UnitTest1
{
    [Fact]
    public void StoreFrontShouldCreate()
    {
        Storefront testStoreFront = new Storefront();

        Assert.NotNull(testStoreFront);
    }

    [Fact]
    public void StorefrontShouldSetValidData()
    {
        // Arrange
        Storefront testStorefront = new Storefront();
        string name = "Test Name";
        string address = "Test Address";
        string city = "Test City";
        string state = "Test State";

        // Act
        testStorefront.Name = name;
        testStorefront.Address = address;
        testStorefront.City = city;
        testStorefront.State = state;

        // Assert
        Assert.Equal(name, testStorefront.Name);
        Assert.Equal(address, testStorefront.Address);
        Assert.Equal(city, testStorefront.City);
        Assert.Equal(state, testStorefront.State);
    }

    [Theory]
    [InlineData("#$%")]
    [InlineData(null)]
    [InlineData(" ")]
    public void StorefrontShouldNotSetInvalidName(string input)
    {
        Storefront testStorefront = new Storefront();

        Assert.Throws<InputInvalidException>(() => testStorefront.Name = input);
    }

    [Fact]
    public void StorefrontShouldHaveCustomToStringMethod()
    {
        Storefront testStorefront = new Storefront{
            Name = "Test Storefront",
            Address = "Test Address",
            City = "Test City",
            State = "Test State",
        };

        string expectedOutput = "Store: Test Storefront \nAddress: Test Address \nCity: Test City \nState: Test State";

        Assert.Equal(expectedOutput, testStorefront.ToString());
    }

    [Fact]
    public void StorefrontInventoryShouldBeAbleToSet()
    {
        Storefront testStorefront = new Storefront();
        List<Inventory> testInventories = new List<Inventory>();
        int testInventoryCount = 0;

        testStorefront.Inventories = testInventories;

        Assert.NotNull(testStorefront.Inventories);
        Assert.Equal(0, testStorefront.Inventories.Count);

    }

    [Fact]
    public void StorefrontOrdersShouldBeAbleToSet()
    {
        Storefront testStorefront = new Storefront();
        List<Order> testOrders = new List<Order>();
        int testOrderCount = 0;

        testStorefront.Orders = testOrders;

        Assert.NotNull(testStorefront.Orders);
        Assert.Equal(0, testStorefront.Orders.Count);

    }

    [Fact]
    public void UserShouldCreate()
    {
        User testUser = new User();
        
        Assert.NotNull(testUser);
    }

    [Theory]
    [InlineData("")]
    [InlineData("asdf")]
    [InlineData("asdf5")]
    [InlineData("111111")]
    [InlineData(null)]
    public void CustomerShouldNotSetInvalidZipCode(string input)
    {
        Customer testCustomer = new Customer();

        Assert.Throws<InputInvalidException>(() => testCustomer.ZipCode = input);
    }

    [Fact]
    public void CustomerOrdersShouldBeAbleToSet()
    {
        Customer testCustomer = new Customer();
        List<Order> testOrders = new List<Order>();
        int testOrderCount = 0;

        testCustomer.Orders = testOrders;

        Assert.NotNull(testCustomer.Orders);
        Assert.Equal(0, testCustomer.Orders.Count);

    }

    [Fact]
    public void ProductShouldCreate()
    {
        Product testProduct = new Product();

        Assert.NotNull(testProduct);
    }

    [Fact]
    public void OrderShouldCreate()
    {
        Order testOrder = new Order();

        Assert.NotNull(testOrder);
    }

    [Fact]
    public void LineItemShouldCreate()
    {
        LineItem testLineItem = new LineItem();

        Assert.NotNull(testLineItem);
    }

    [Fact]
    public void InventoryShouldCreate()
    {
        Inventory testInventory = new Inventory();

        Assert.NotNull(testInventory);
    }
}

// Code coverage calculates how much of the code base is tested. To run: dotnet test --collect:"XPlat Code Coverage"