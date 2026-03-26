using Soenneker.ProductBoard.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.ProductBoard.HttpClients.Tests;

[Collection("Collection")]
public sealed class ProductBoardOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IProductBoardOpenApiHttpClient _httpclient;

    public ProductBoardOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IProductBoardOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
