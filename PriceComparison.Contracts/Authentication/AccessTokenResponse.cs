namespace PriceComparison.Contracts.Authentication;

public record AccessTokenResponse(
    string AccessToken,
    string RefreshToken,
    DateTimeOffset ExpiresAt);