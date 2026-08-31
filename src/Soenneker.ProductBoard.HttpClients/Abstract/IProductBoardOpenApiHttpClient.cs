using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Threading;

namespace Soenneker.ProductBoard.HttpClients.Abstract;

/// <summary>
/// Provides an authenticated HTTP client for Productboard API v2.
/// </summary>
public interface IProductBoardOpenApiHttpClient: IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the cached client owned by this provider.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>The configured HTTP client.</returns>
    ValueTask<HttpClient> Get(CancellationToken cancellationToken = default);
}
