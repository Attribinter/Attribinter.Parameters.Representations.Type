namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByOrdinalAndNameQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>
{
    private readonly ITypeParameterRepresentationWithOrdinalAndNameFactory TypeParameterRepresentationFactory;

    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalAndNameQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    /// <param name="typeParameterRepresentationFactory">Handles creation of <see cref="ITypeParameterRepresentation"/>.</param>
    public GetTypeParameterRepresentationByOrdinalAndNameQueryHandler(
        ITypeParameterRepresentationWithOrdinalAndNameFactory typeParameterRepresentationFactory)
    {
        TypeParameterRepresentationFactory = typeParameterRepresentationFactory ?? throw new ArgumentNullException(nameof(typeParameterRepresentationFactory));
    }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByOrdinalAndNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return TypeParameterRepresentationFactory.Create(query.Ordinal, query.Name);
    }
}
