namespace Attribinter.Parameters.Representations.IndexedAndNamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal sealed class ComparerContext
{
    public static ComparerContext Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory factory = new IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory();

        var comparer = factory.Create(nameComparerMock.Object);

        return new(comparer, nameComparerMock);
    }

    public IEqualityComparer<ITypeParameterRepresentation> Comparer { get; }

    public Mock<IEqualityComparer<string>> NameComparerMock { get; }

    private ComparerContext(IEqualityComparer<ITypeParameterRepresentation> comparer, Mock<IEqualityComparer<string>> nameComparerMock)
    {
        Comparer = comparer;

        NameComparerMock = nameComparerMock;
    }
}
