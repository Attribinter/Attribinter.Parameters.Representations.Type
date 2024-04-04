namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="INamedTypeParameterRepresentationFactory"/>
public sealed class NamedTypeParameterRepresentationFactory : INamedTypeParameterRepresentationFactory
{
    /// <summary>Instantiates a <see cref="NamedTypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/> using the names of type parameters.</summary>
    public NamedTypeParameterRepresentationFactory() { }

    ITypeParameterRepresentation INamedTypeParameterRepresentationFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new TypeParameterRepresentation(name);
    }

    private sealed class TypeParameterRepresentation : ITypeParameterRepresentation
    {
        private readonly string Name;

        public TypeParameterRepresentation(string name)
        {
            Name = name;
        }

        bool ITypeParameterRepresentation.IsIndexKnown => false;
        bool ITypeParameterRepresentation.IsNameKnown => true;

        int ITypeParameterRepresentation.GetIndex() => throw new InvalidOperationException("Cannot retrieve the index of the represented type parameter, as it is not known.");
        string ITypeParameterRepresentation.GetName() => Name;
    }
}
