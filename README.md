[![GitHub](https://img.shields.io/github/license/fullstackhero/blazor-wasm-boilerplate?color=2da44e&style=flat-square)](https://github.com/fullstackhero/blazor-wasm-boilerplate/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/878181478972928011?color=%237289da&label=Discord&logo=discord&logoColor=%237289da&style=flat-square)](https://discord.gg/yQWpShsKrf)
[![Twitter](https://img.shields.io/twitter/follow/codewithmukesh?color=1DA1F2&label=Twitter&logo=Twitter&style=flat-square)](https://twitter.com/codewithmukesh)

<p align="center">
    <img src="https://codewithmukesh.com/wp-content/uploads/2022/02/fullstackhero-blazor-wasm-banner.png" alt="fullstackhero">
</p>

# Blazor WebAssembly Boilerplate 
Built with .NET 8.0 and the goodness of MudBlazor Component Library. Incorporates the most essential Packages your projects will ever need. Follows Clean Architecture Principles.

## Goals

The goal of this repository is to help developers / companies kickstart their Web Application Development with a pre-built Blazor WebAssembly Boilerplate that includes several much needed components and features.

> Note that this is a frontend / client application only! The backend for this application is available in a seperate repository. 
> - Find fullstackhero's .NET Web API Boilerplate here - https://github.com/fullstackhero/dotnet-webapi-boilerplate

## Prerequisites

- Make sure you have the API Running. Here is FSH Backend - https://github.com/fullstackhero/dotnet-webapi-boilerplate
- Once fullstackhero's .NET Web API is up and running, run the Blazor WebAssembly Project to consume it's services.

## Getting Started

Open up your Command Prompt / Powershell and run the following command to install the solution template.

```powershell
dotnet new --install FullStackHero.BlazorWebAssembly.Boilerplate
```
or, if you want to use a specific version of the boilerplate, use

```powershell
dotnet new --install FullStackHero.BlazorWebAssembly.Boilerplate::0.0.1-rc
```
This would install the `fullstackhero Blazor WebAssembly Boilerplate` template globally on your machine. Do note that, at the time of writing this documentation, the latest available version is **0.0.1-rc** which is also one of the first stable pre-release version of the package. It is highly likely that there is already a newer version available when you are reading this.

> *To get the latest version of the package, visit [nuget.org](https://www.nuget.org/packages/FullStackHero.BlazorWebAssembly.Boilerplate/)*
>
> *FullStackHero.BlazorWebAssembly.Boilerplate is now in pre-release state. You can find the latest version on NuGet.org*

**This .NET 8.0 version of the Blazor WebAssembly Boilerplate requires a compatible .NET 8.0 backend.**

Get the .NET WebApi Boilerplate by running the following command

```
dotnet new --install FullStackHero.WebAPI.Boilerplate
```

For more details on getting started, [read this article](https://fullstackhero.net/blazor-webassembly-boilerplate/general/getting-started/)

## .NET 8.0 Upgrade Notes

This project has been upgraded from .NET 6.0 to .NET 8.0. The upgrade includes:

- Updated target framework from `net6.0` to `net8.0` in all project files
- Updated NuGet package references to .NET 8.0 compatible versions:
  - Microsoft.AspNetCore.Components.WebAssembly: 6.0.5 → 8.0.15
  - Microsoft.AspNetCore.Components.WebAssembly.DevServer: 6.0.5 → 8.0.15
  - Microsoft.AspNetCore.Components.Authorization: 6.0.5 → 8.0.15
  - Microsoft.AspNetCore.SignalR.Client: 6.0.5 → 8.0.15
  - Microsoft.Authentication.WebAssembly.Msal: 6.0.5 → 8.0.15
  - Microsoft.Extensions.Caching.Memory: 6.0.1 → 8.0.1
  - Microsoft.Extensions.Http: 6.0.0 → 8.0.1
  - Microsoft.Extensions.Localization: 6.0.5 → 8.0.15
  - Microsoft.AspNetCore.Components.WebAssembly.Server: 6.0.5 → 8.0.15
  - Newtonsoft.Json: 13.0.1 → 13.0.3
- Updated NSwag configuration to use .NET 8.0
- Fixed API compatibility issues with .NET 8.0
- Added global.json with .NET 8.0 SDK configuration

To upgrade your own project, you can use the .NET Upgrade Assistant:
```
dotnet tool install -g upgrade-assistant
upgrade-assistant analyze YourSolution.sln --targetFramework net8.0
upgrade-assistant upgrade YourSolution.sln
```

## Community

- Discord [@fullstackhero](https://discord.gg/gdgHRt4mMw)
- Facebook Page [@codewithmukesh](https://facebook.com/codewithmukesh)
- Youtube Channel [@codewithmukesh](https://youtube.com/c/codewithmukesh)

## Contributors

Submit your PR and join the elite list!

<a href="https://github.com/fullstackhero/blazor-wasm-boilerplate/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=fullstackhero/blazor-wasm-boilerplate" />
</a>

## License

This project is licensed with the [MIT license](LICENSE).

## Support :star:

Has this Project helped you learn something New? or Helped you at work?
Here are a few ways by which you can support.

-   Leave a star! :star:
-   Recommend this awesome project to your colleagues. 🥇
-   Do consider endorsing me on LinkedIn for ASP.NET Core - [Connect via LinkedIn](https://codewithmukesh.com/linkedin) 🦸
-   Or, If you want to support this project in the long run, [consider buying me a coffee](https://www.buymeacoffee.com/codewithmukesh)! ☕

<br>
    
<a href="https://www.buymeacoffee.com/codewithmukesh"><img width="250" alt="black-button" src="https://user-images.githubusercontent.com/31455818/138557309-27587d91-7b82-4cab-96bb-90f4f4e600f1.png" ></a>
