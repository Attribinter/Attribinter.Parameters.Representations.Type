namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparer;

using System.Collections.Generic;

internal static class FixtureFactory
{
    public static IFixture Create()
    {
        IIndexedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedTypeParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create();

        return new Fixture(sut);
    }

    private sealed class Fixture
        : IFixture
    {
        private readonly IEqualityComparer<ITypeParameterRepresentation> Sut;

        public Fixture(
            IEqualityComparer<ITypeParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IEqualityComparer<ITypeParameterRepresentation> IFixture.Sut => Sut;
    }
}
