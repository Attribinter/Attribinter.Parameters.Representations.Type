namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using System.Collections.Generic;

internal sealed class ComparerContext
{
    public static ComparerContext Create()
    {
        IIndexedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedTypeParameterRepresentationEqualityComparerFactory();

        var comparer = factory.Create();

        return new(comparer);
    }

    public IEqualityComparer<ITypeParameterRepresentation> Comparer { get; }

    private ComparerContext(IEqualityComparer<ITypeParameterRepresentation> comparer)
    {
        Comparer = comparer;
    }
}
