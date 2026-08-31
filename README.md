[![](https://img.shields.io/nuget/v/soenneker.productboard.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.productboard.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.productboard.httpclients/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.productboard.httpclients/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.productboard.httpclients.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.productboard.httpclients/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.productboard.httpclients/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.productboard.httpclients/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.ProductBoard.HttpClients

Provides a cached, bearer-authenticated `HttpClient` for Productboard notes, entities, members, teams, configurations, and other API v2 resources.

## Installation

```bash
dotnet add package Soenneker.ProductBoard.HttpClients
```

## Configuration

```json
{
  "ProductBoard": {
    "ApiKey": "your-api-or-oauth-token"
  }
}
```

The default base URL is `https://api.productboard.com/v2/`. `ProductBoard:ClientBaseUrl` can override it for a compatible proxy.

## Usage

```csharp
using Soenneker.ProductBoard.HttpClients.Abstract;
using Soenneker.ProductBoard.HttpClients.Registrars;

services.AddProductBoardOpenApiHttpClientAsSingleton();

IProductBoardOpenApiHttpClient productboard = serviceProvider
    .GetRequiredService<IProductBoardOpenApiHttpClient>();

HttpClient client = await productboard.Get(cancellationToken);
HttpResponseMessage response = await client.GetAsync(
    "notes",
    cancellationToken);
response.EnsureSuccessStatusCode();
```

The provider owns the cached client. Scoped provider registrations use separate cache entries, so disposing one scope does not invalidate another scope's client.
