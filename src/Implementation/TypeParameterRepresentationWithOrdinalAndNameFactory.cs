namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationWithOrdinalAndNameFactory"/>
public sealed class TypeParameterRepresentationWithOrdinalAndNameFactory
    : ITypeParameterRepresentationWithOrdinalAndNameFactory
{
    /// <summary>Instantiates a <see cref="TypeParameterRepresentationWithOrdinalAndNameFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    public TypeParameterRepresentationWithOrdinalAndNameFactory() { }

    ITypeParameterRepresentation ITypeParameterRepresentationWithOrdinalAndNameFactory.Create(
        int ordinal,
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new TypeParameterRepresentation(ordinal, name);
    }

    private sealed class TypeParameterRepresentation
        : ITypeParameterRepresentation
    {
        private readonly int Ordinal;
        private readonly string Name;

        public TypeParameterRepresentation(
            int ordinal,
            string name)
        {
            Ordinal = ordinal;
            Name = name;
        }

        bool ITypeParameterRepresentation.IsOrdinalKnown => true;
        bool ITypeParameterRepresentation.IsNameKnown => true;

        int ITypeParameterRepresentation.GetOrdinal() => Ordinal;
        string ITypeParameterRepresentation.GetName() => Name;
    }
}
