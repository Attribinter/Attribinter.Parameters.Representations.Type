namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IIndexedAndNamedTypeParameterRepresentationFactory"/>
public sealed class IndexedAndNamedTypeParameterRepresentationFactory : IIndexedAndNamedTypeParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="IndexedAndNamedTypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</summary>
    public IndexedAndNamedTypeParameterRepresentationFactory() { }

    ITypeParameterRepresentation IIndexedAndNamedTypeParameterRepresentationFactory.Create(int index, string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new TypeParameterRepresentation(index, name);
    }

    private sealed class TypeParameterRepresentation : ITypeParameterRepresentation
    {
        private readonly int Index;
        private readonly string Name;

        public TypeParameterRepresentation(int index, string name)
        {
            Index = index;
            Name = name;
        }

        bool ITypeParameterRepresentation.IsIndexKnown => true;
        bool ITypeParameterRepresentation.IsNameKnown => true;

        int ITypeParameterRepresentation.GetIndex() => Index;
        string ITypeParameterRepresentation.GetName() => Name;
    }
}
