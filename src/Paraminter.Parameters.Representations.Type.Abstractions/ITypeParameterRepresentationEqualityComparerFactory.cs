namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

/// <summary>Handles creation of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
public interface ITypeParameterRepresentationEqualityComparerFactory
{
    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the indices and names of type parameter representations.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of type parameters.</param>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> CreateIndexedAndNamed(IEqualityComparer<string> nameComparer);

    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the indices of type parameter representations.</summary>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> CreateIndexed();

    /// <summary>Creates a comparer of <see cref="ITypeParameterRepresentation"/> which considers the names of type parameter representations.</summary>
    /// <param name="nameComparer">Determines equality when comparing the names of type parameters.</param>
    /// <returns>The created comparer of <see cref="ITypeParameterRepresentation"/>.</returns>
    public abstract IEqualityComparer<ITypeParameterRepresentation> CreateNamed(IEqualityComparer<string> nameComparer);
}
