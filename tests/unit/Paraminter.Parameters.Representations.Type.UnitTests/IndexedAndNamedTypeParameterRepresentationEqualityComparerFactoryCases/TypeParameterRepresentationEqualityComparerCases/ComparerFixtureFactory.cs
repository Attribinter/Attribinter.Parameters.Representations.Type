namespace Paraminter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new ComparerFixture(sut, nameComparerMock);
    }

    private sealed class ComparerFixture
        : IComparerFixture
    {
        private readonly IEqualityComparer<ITypeParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public ComparerFixture(
            IEqualityComparer<ITypeParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;
            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<ITypeParameterRepresentation> IComparerFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IComparerFixture.NameComparerMock => NameComparerMock;
    }
}
