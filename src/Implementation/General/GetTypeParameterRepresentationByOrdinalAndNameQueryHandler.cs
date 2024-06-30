namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByOrdinalAndNameQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalAndNameQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    public GetTypeParameterRepresentationByOrdinalAndNameQueryHandler() { }

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
