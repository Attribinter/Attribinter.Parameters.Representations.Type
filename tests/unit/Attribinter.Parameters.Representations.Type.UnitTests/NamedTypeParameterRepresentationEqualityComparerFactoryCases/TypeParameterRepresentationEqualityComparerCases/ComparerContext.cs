namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal sealed class ComparerContext
{
    public static ComparerContext Create()
    {
        Mock<IEqualityComparer<string>> nameComparerMock = new();

        INamedTypeParameterRepresentationEqualityComparerFactory factory = new NamedTypeParameterRepresentationEqualityComparerFactory();

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
