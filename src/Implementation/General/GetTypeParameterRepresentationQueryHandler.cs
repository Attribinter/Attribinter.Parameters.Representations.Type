namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetParameterRepresentationQuery{TParameter}"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationQueryHandler
    : IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>
{
    private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> ByOrdinalAndNameQueryHandler;

    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationQueryHandler"/>, handling <see cref="IGetParameterRepresentationQuery{TParameter}"/>.</summary>
    /// <param name="byOrdinalAndNameQueryHandler">Handles <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</param>
    public GetTypeParameterRepresentationQueryHandler(
        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> byOrdinalAndNameQueryHandler)
    {
        ByOrdinalAndNameQueryHandler = byOrdinalAndNameQueryHandler ?? throw new ArgumentNullException(nameof(byOrdinalAndNameQueryHandler));
    }

    ITypeParameterRepresentation IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>.Handle(
        IGetParameterRepresentationQuery<ITypeParameter> query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        var byOrdinalAndNameQuery = GetTypeParameterRepresentationByOrdinalAndNameQueryFactory.FromParameter(query.Parameter);

        return ByOrdinalAndNameQueryHandler.Handle(byOrdinalAndNameQuery);
    }
}
