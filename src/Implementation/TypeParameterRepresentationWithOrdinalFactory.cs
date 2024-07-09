namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the ordinals of type parameters.</summary>
public sealed class TypeParameterRepresentationWithOrdinalFactory
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="TypeParameterRepresentationWithOrdinalFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    public TypeParameterRepresentationWithOrdinalFactory() { }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByOrdinalQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new TypeParameterRepresentation(query.Ordinal);
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
