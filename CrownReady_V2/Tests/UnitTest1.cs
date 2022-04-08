// To create xunit tests, run: dotnet new xunit -n Tests  
// Once created, run: dotnet add package xUnit  
using Xunit;
using Models;

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
}