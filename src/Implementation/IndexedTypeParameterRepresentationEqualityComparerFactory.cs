namespace Paraminter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="IIndexedTypeParameterRepresentationEqualityComparerFactory"/>
public sealed class IndexedTypeParameterRepresentationEqualityComparerFactory
    : IIndexedTypeParameterRepresentationEqualityComparerFactory
{
    /// <summary>Instantiates a <see cref="IndexedTypeParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="ITypeParameterRepresentation"/> which consider the indices of type parameter representations.</summary>
    public IndexedTypeParameterRepresentationEqualityComparerFactory() { }

    IEqualityComparer<ITypeParameterRepresentation> IIndexedTypeParameterRepresentationEqualityComparerFactory.Create() => TypeParameterRepresentationEqualityComparer.Instance;

    private sealed class TypeParameterRepresentationEqualityComparer
        : IEqualityComparer<ITypeParameterRepresentation>
    {
        public static IEqualityComparer<ITypeParameterRepresentation> Instance { get; } = new TypeParameterRepresentationEqualityComparer();

        private TypeParameterRepresentationEqualityComparer() { }

        bool IEqualityComparer<ITypeParameterRepresentation>.Equals(
            ITypeParameterRepresentation x,
            ITypeParameterRepresentation y)
        {
            if (x is null)
            {
                throw new ArgumentNullException(nameof(x));
            }

            if (y is null)
            {
                throw new ArgumentNullException(nameof(y));
            }

            ValidateRepresentation(x, nameof(x));
            ValidateRepresentation(y, nameof(y));

            return x.GetIndex() == y.GetIndex();
        }

        int IEqualityComparer<ITypeParameterRepresentation>.GetHashCode(
            ITypeParameterRepresentation obj)
        {
            if (obj is null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            ValidateRepresentation(obj, nameof(obj));

            return obj.GetIndex().GetHashCode();
        }

        private static void ValidateRepresentation(
            ITypeParameterRepresentation representation,
            string paramName)
        {
            if (representation.IsIndexKnown is false)
            {
                throw new ArgumentException("Expected the index of the represented type parameter to be known.", paramName);
            }
        }
    }
}
