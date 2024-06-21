namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices and names of type parameter representations.</summary>
public interface IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the indices and names of type parameter representations.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of type parameters.</param>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> Create(
        IEqualityComparer<string> nameComparer);
}
