namespace PriceComparison.Contracts.Products;

public record UpdateProductRequest(
    string Slug,
    string Name,
    string Description,
    IDictionary<Guid, double> Prices);