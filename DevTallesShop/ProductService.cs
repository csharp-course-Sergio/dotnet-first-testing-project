using System;

namespace DevTallesShop;

public class ProductService
{
    private readonly List<Product> _products =
    [
        new Product(1, "Laptop", 850m),
        new Product(2, "Keyboard", 30m),
        new Product(3, "Monitor", 120m),
        new Product(4, "USB", 8m),
        new Product(5, "Mouse", 15m),
    ];

    public IEnumerable<Product> GetProductsByMinimumPrice(decimal minimumPrice)
    {
        return _products.Where(p => p.Price >= minimumPrice);
    }
}
