﻿namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryProviderCases;

using Xunit;

public sealed class IndexedAndNamedFactory
{
    private readonly IProviderFixture Fixture = ProviderFixtureFactory.Create();

    [Fact]
    public void ReturnsSameAsConstructedWith()
    {
        var result = Target();

        Assert.Same(Fixture.IndexedAndNamedFactoryMock.Object, result);
    }

    private IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory Target() => Fixture.Sut.IndexedAndNamedFactory;
}
