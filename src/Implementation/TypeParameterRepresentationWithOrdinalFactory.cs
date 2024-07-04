namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationWithOrdinalFactory"/>
public sealed class TypeParameterRepresentationWithOrdinalFactory
    : ITypeParameterRepresentationWithOrdinalFactory
{
    /// <summary>Instantiates a <see cref="TypeParameterRepresentationWithOrdinalFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    public TypeParameterRepresentationWithOrdinalFactory() { }

    ITypeParameterRepresentation ITypeParameterRepresentationWithOrdinalFactory.Create(
        int ordinal)
    {
        return new TypeParameterRepresentation(ordinal);
    }

    private sealed class TypeParameterRepresentation
        : ITypeParameterRepresentation
    {
        private readonly int Ordinal;

        public TypeParameterRepresentation(
            int ordinal)
        {
            Ordinal = ordinal;
        }

        bool ITypeParameterRepresentation.IsOrdinalKnown => true;
        bool ITypeParameterRepresentation.IsNameKnown => false;

        int ITypeParameterRepresentation.GetOrdinal() => Ordinal;
        string ITypeParameterRepresentation.GetName() => throw new InvalidOperationException("Cannot retrieve the name of the represented type parameter, as it is not known.");
    }
}
