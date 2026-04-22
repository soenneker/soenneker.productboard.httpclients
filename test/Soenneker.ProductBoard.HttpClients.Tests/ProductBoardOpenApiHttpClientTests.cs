using Soenneker.ProductBoard.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.ProductBoard.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ProductBoardOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IProductBoardOpenApiHttpClient _httpclient;

    public ProductBoardOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IProductBoardOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
