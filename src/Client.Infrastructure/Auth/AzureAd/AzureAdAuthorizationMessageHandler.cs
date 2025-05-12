using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using System.Collections.Generic;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Auth.AzureAd;

public class AzureAdAuthorizationMessageHandler : AuthorizationMessageHandler
{
    public AzureAdAuthorizationMessageHandler(IAccessTokenProvider provider, NavigationManager navigation, IConfiguration config)
        : base(provider, navigation)
    {
        string? apiBaseUrl = config[ConfigNames.ApiBaseUrl];
        string? apiScope = config[$"{nameof(AuthProvider.AzureAd)}:{ConfigNames.ApiScope}"];
        if (!string.IsNullOrEmpty(apiBaseUrl) && !string.IsNullOrEmpty(apiScope))
        {
            ConfigureHandler(
                authorizedUrls: new List<string> { apiBaseUrl },
                scopes: new List<string> { apiScope });
        }
    }
}
