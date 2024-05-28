namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        INamedTypeParameterRepresentationEqualityComparerFactory factory = new NamedTypeParameterRepresentationEqualityComparerFactory();

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
