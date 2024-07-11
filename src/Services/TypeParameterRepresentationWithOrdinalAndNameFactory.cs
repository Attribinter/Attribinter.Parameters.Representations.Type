namespace Paraminter.Parameters.Representations.Type;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

using System;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using the ordinals and names of type parameters.</summary>
public sealed class TypeParameterRepresentationWithOrdinalAndNameFactory
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="TypeParameterRepresentationWithOrdinalAndNameFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    public TypeParameterRepresentationWithOrdinalAndNameFactory() { }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByOrdinalAndNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new TypeParameterRepresentation(query.Ordinal, query.Name);
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
