using FluentAssertions;
using ntitsolutions.Application.Tarifas.Queries.GetTarifas;
using ntitsolutions.Domain.ValueObjects;
using NUnit.Framework;

namespace ntitsolutions.Application.IntegrationTests.Tarifas.Queries;

using static Testing;

public class GetPlanosTests : BaseTestFixture
{
    [Test]
    public async Task ShouldReturnTarifas()
    {
        await RunAsDefaultUserAsync();

        var query = new GetTarifasQuery();

        var result = await SendAsync(query);

        result.Should().NotBeEmpty();
    }
}
