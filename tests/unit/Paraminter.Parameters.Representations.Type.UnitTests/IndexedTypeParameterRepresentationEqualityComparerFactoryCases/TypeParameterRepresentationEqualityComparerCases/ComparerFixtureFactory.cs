namespace Paraminter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using System.Collections.Generic;

internal static class ComparerFixtureFactory
{
    public static IComparerFixture Create()
    {
        IIndexedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedTypeParameterRepresentationEqualityComparerFactory();

        var sut = factory.Create();

        return new ComparerFixture(sut);
    }

    private sealed class ComparerFixture : IComparerFixture
    {
        private readonly IEqualityComparer<ITypeParameterRepresentation> Sut;

        public ComparerFixture(IEqualityComparer<ITypeParameterRepresentation> sut)
        {
            Sut = sut;
        }

        IEqualityComparer<ITypeParameterRepresentation> IComparerFixture.Sut => Sut;
    }
}
