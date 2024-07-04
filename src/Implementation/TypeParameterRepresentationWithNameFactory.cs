namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationWithNameFactory"/>
public sealed class TypeParameterRepresentationWithNameFactory
    : ITypeParameterRepresentationWithNameFactory
{
    /// <summary>Instantiates a <see cref="TypeParameterRepresentationWithNameFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    public TypeParameterRepresentationWithNameFactory() { }

    ITypeParameterRepresentation ITypeParameterRepresentationWithNameFactory.Create(
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new TypeParameterRepresentation(name);
    }

    private sealed class TypeParameterRepresentation
        : ITypeParameterRepresentation
    {
        private readonly string Name;

        public TypeParameterRepresentation(
            string name)
        {
            Name = name;
        }

        bool ITypeParameterRepresentation.IsOrdinalKnown => false;
        bool ITypeParameterRepresentation.IsNameKnown => true;

        int ITypeParameterRepresentation.GetOrdinal() => throw new InvalidOperationException("Cannot retrieve the ordinal of the represented type parameter, as it is not known.");
        string ITypeParameterRepresentation.GetName() => Name;
    }
}
