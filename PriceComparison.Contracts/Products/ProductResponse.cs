namespace PriceComparison.Contracts.Products;

public record ProductResponse(
    Guid Id,
    string Name,
    string Description,
    List<ProductPriceResponse> Price);

public record ProductPriceResponse(Guid MerchantId, double Price);