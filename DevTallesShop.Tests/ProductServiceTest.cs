using System;

namespace DevTallesShop.Tests;

public class ProductServiceTest
{

    [Fact]
    public void GetProductsByMinimumPrice_MinimumPrice30_RetursAtLeastOneProduct()
    {
        var service = new ProductService();
        var minimumPrice = 30m;

        var result = service.GetProductsByMinimumPrice(minimumPrice).ToList();

        Assert.NotEmpty(result);
    }

    [Fact]
    public void GetProductsByMinimumPrice_MinimumPrice30_ReturnsOnlyProductsWithPriceGreaterOrEqualTo30()
    {
        var service = new ProductService();
        var minimumPrice = 30m;

        var result = service.GetProductsByMinimumPrice(minimumPrice).ToList();

        Assert.All(result, p => Assert.True(p.Price >= minimumPrice));
    }

    [Fact]
    public void GetProductsByMinimumPrice_MinimumPrice30_DoesNotReturnProductsCheaperThan30()
    {
        var service = new ProductService();
        var minimumPrice = 30m;

        var result = service.GetProductsByMinimumPrice(minimumPrice).ToList();

        Assert.DoesNotContain(result, product => product.Price < minimumPrice);
    }

    [Fact]
    public void GetProductsByMinimumPrice_GivenVeryHighMinimumPrice_ReturnsEmptyCollection()
    {
        var service = new ProductService();
        var minimumPrice = 1000m;

        var result = service.GetProductsByMinimumPrice(minimumPrice).ToList();

        Assert.Empty(result);
    }

    [Fact]
    public void GetProductsByMinimumPrice_GivenMinimumPrice_ReturnsAllProducts()
    {
        var service = new ProductService();
        var minimumPrice = 0m;

        var result = service.GetProductsByMinimumPrice(minimumPrice).ToList();

        Assert.Equal(5, result.Count);
    }
}
