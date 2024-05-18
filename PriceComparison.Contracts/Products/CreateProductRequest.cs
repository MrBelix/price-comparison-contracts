namespace PriceComparison.Contracts.Products;

public record CreateProductRequest(
    string Slug,
    string Name,
    string Description,
    IDictionary<Guid, double> Prices);