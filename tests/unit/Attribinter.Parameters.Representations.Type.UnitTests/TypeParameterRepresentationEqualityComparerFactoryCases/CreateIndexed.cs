namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System.Collections.Generic;

using Xunit;

public sealed class CreateIndexed
{
    private IEqualityComparer<ITypeParameterRepresentation> Target() => Fixture.Sut.CreateIndexed();

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void ReturnsComparer()
    {
        var comparer = Mock.Of<IEqualityComparer<ITypeParameterRepresentation>>();

        Fixture.FactoryProviderMock.Setup(static (provider) => provider.IndexedFactory.Create()).Returns(comparer);

        var result = Target();

        Assert.Equal(comparer, result);
    }
}
