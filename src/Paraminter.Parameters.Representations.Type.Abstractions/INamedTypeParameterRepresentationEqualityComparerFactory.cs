namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the names of type parameter representations.</summary>
public interface INamedTypeParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the names of type parameter representations.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of type parameters.</param>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> Create(
        IEqualityComparer<string> nameComparer);
}
