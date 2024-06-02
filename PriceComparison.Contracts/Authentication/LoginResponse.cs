namespace PriceComparison.Contracts.Authentication;

public record LoginResponse(
    string AccessToken,
    string RefreshToken,
    DateTimeOffset ExpiresAt);