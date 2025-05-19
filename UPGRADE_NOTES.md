# Upgrade to .NET 8.0 Notes

This document describes the process of upgrading the Blazor WebAssembly Boilerplate from .NET 6.0 to .NET 8.0.

## Analysis Results

The upgrade-assistant analysis identified the following issues:
- 6 mandatory issues
- 5 optional issues
- 340 potential issues (total: 351 incidents)
- Categories: 18 NuGet-related, 4 Project-related, and 329 API-related

Key mandatory issues included:
- NuGet packages with functionality now included in framework references that needed to be removed
- Project target frameworks that needed to be updated from .NET 6.0 to .NET 8.0

## Upgrade Process

1. Used the .NET Upgrade Assistant tool to analyze upgrade readiness:
   ```
   upgrade-assistant analyze FSH.BlazorWebAssembly.sln --targetFramework net8.0 --report BlazorWasmUpgradeReport
   ```

2. Created a visualization of the analysis report to better understand the upgrade complexity

3. Used the .NET Upgrade Assistant tool to perform the upgrade for each project:
   ```
   upgrade-assistant upgrade src/Client/Client.csproj --targetFramework net8.0 --operation Inplace --non-interactive
   upgrade-assistant upgrade src/Client.Infrastructure/Client.Infrastructure.csproj --targetFramework net8.0 --operation Inplace --non-interactive
   upgrade-assistant upgrade src/Host/Host.csproj --targetFramework net8.0 --operation Inplace --non-interactive
   upgrade-assistant upgrade src/Shared/Shared.csproj --targetFramework net8.0 --operation Inplace --non-interactive
   ```

4. Updated the global.json file to target .NET 8.0

## Issues Encountered

1. **Interactive Mode Issues**: The upgrade-assistant tool in interactive mode got stuck waiting for input. Resolved by using the `--operation Inplace --non-interactive` flags to specify the exact upgrade operation.

2. **Build Issues**: After upgrading all projects to .NET 8.0, building the solution fails with error NETSDK1045 because the current .NET SDK (6.0.428) doesn't support targeting .NET 8.0. To resolve this, the .NET 8.0 SDK needs to be installed.

## Changes Made

1. Updated target framework to .NET 8.0 in all project files:
   - src/Client/Client.csproj
   - src/Client.Infrastructure/Client.Infrastructure.csproj
   - src/Host/Host.csproj
   - src/Shared/Shared.csproj

2. Updated NuGet package references to .NET 8.0 versions:
   - Microsoft.AspNetCore.Components.WebAssembly: 8.0.16
   - Microsoft.AspNetCore.Components.WebAssembly.DevServer: 8.0.16
   - Microsoft.AspNetCore.Components.Authorization: 8.0.16
   - Microsoft.AspNetCore.SignalR.Client: 8.0.16
   - Microsoft.Authentication.WebAssembly.Msal: 8.0.16
   - Microsoft.Extensions.Localization: 8.0.16
   - Microsoft.AspNetCore.Components.WebAssembly.Server: 8.0.16

3. Updated global.json to target .NET 8.0

## Next Steps

1. Install .NET 8.0 SDK to build and run the upgraded solution
2. Test the application thoroughly to ensure all functionality works as expected
3. Address any runtime issues that may arise due to API changes in .NET 8.0
