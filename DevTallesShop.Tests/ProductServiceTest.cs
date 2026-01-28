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
}
