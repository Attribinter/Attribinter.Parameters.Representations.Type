namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases;

using System.Collections.Generic;

using Xunit;

public sealed class Create
{
    private IEqualityComparer<ITypeParameterRepresentation> Target() => Fixture.Sut.Create();

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void ReturnsComparer()
    {
        var result = Target();

        Assert.NotNull(result);
    }
}
