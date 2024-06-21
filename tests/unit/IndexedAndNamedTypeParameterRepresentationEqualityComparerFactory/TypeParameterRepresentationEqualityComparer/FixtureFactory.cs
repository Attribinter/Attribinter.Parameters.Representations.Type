namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create(nameComparerMock.Object);

        return new Fixture(sut, nameComparerMock);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IEqualityComparer<ITypeParameterRepresentation> Sut;

        private readonly Mock<IEqualityComparer<string>> NameComparerMock;

        public Fixture(
            IEqualityComparer<ITypeParameterRepresentation> sut,
            Mock<IEqualityComparer<string>> nameComparerMock)
        {
            Sut = sut;
            NameComparerMock = nameComparerMock;
        }

        IEqualityComparer<ITypeParameterRepresentation> IFixture.Sut => Sut;

        Mock<IEqualityComparer<string>> IFixture.NameComparerMock => NameComparerMock;
    }
}
