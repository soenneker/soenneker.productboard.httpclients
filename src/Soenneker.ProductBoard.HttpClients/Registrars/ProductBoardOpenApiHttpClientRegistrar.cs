using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.ProductBoard.HttpClients.Abstract;
using Soenneker.Utils.HttpClientCache.Registrar;

namespace Soenneker.ProductBoard.HttpClients.Registrars;

/// <summary>
/// Registers the OpenAPI HttpClient wrapper for dependency injection.
/// </summary>
public static class ProductBoardOpenApiHttpClientRegistrar
{
    /// <summary>
    /// Adds <see cref="ProductBoardOpenApiHttpClient"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddProductBoardOpenApiHttpClientAsSingleton(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddSingleton<IProductBoardOpenApiHttpClient, ProductBoardOpenApiHttpClient>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ProductBoardOpenApiHttpClient"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddProductBoardOpenApiHttpClientAsScoped(this IServiceCollection services)
    {
        services.AddHttpClientCacheAsSingleton()
                .TryAddScoped<IProductBoardOpenApiHttpClient, ProductBoardOpenApiHttpClient>();

        return services;
    }
}
