namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class CreateIndexedAndNamed
{
    private IEqualityComparer<ITypeParameterRepresentation> Target(IEqualityComparer<string> nameComparer) => Fixture.Sut.CreateIndexedAndNamed(nameComparer);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullNameComparer_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidNameComparer_ReturnsComparer()
    {
        var nameComparer = Mock.Of<IEqualityComparer<string>>();

        var comparer = Mock.Of<IEqualityComparer<ITypeParameterRepresentation>>();

        Fixture.FactoryProviderMock.Setup((provider) => provider.IndexedAndNamedFactory.Create(nameComparer)).Returns(comparer);

        var result = Target(nameComparer);

        Assert.Equal(comparer, result);
    }
}
