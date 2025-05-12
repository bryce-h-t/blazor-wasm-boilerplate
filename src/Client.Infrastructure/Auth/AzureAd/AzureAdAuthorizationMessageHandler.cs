using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Auth.AzureAd;

public class AzureAdAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public AzureAdAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation, IConfiguration config)
        : base(provider, navigation) => ConfigureHandler(
            authorizedUrls: new[] { config[ConfigNames.ApiBaseUrl] ?? string.Empty },
            scopes: new[] { config[$"{nameof(AuthProvider.AzureAd)}:{ConfigNames.ApiScope}"] ?? string.Empty });
}
