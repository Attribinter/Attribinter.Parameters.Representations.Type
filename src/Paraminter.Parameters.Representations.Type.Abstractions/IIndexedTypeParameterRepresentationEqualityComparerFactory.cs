namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</summary>
public interface IIndexedTypeParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the indices type parameter representations.</summary>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> Create();
}
