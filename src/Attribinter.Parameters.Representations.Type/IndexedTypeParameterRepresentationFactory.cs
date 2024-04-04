namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="IIndexedTypeParameterRepresentationFactory"/>
public sealed class IndexedTypeParameterRepresentationFactory : IIndexedTypeParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="IndexedTypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/> using the indices of type parameters.</summary>
    public IndexedTypeParameterRepresentationFactory() { }

    ITypeParameterRepresentation IIndexedTypeParameterRepresentationFactory.Create(int index) => new TypeParameterRepresentation(index);

    private sealed class TypeParameterRepresentation : ITypeParameterRepresentation
    {
        private readonly int Index;

        public TypeParameterRepresentation(int index)
        {
            Index = index;
        }

        bool ITypeParameterRepresentation.IsIndexKnown => true;
        bool ITypeParameterRepresentation.IsNameKnown => false;

        int ITypeParameterRepresentation.GetIndex() => Index;
        string ITypeParameterRepresentation.GetName() => throw new InvalidOperationException("Cannot retrieve the name of the represented type parameter, as it is not known.");
    }
}
