namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetParameterRepresentationQuery{TParameter}"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationQueryHandler
    : IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>
{
    private readonly IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory ByOrdinalAndNameQueryFactory;
    private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> ByOrdinalAndNameQueryHandler;

    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationQueryHandler"/>, handling <see cref="IGetParameterRepresentationQuery{TParameter}"/>.</summary>
    /// <param name="byOrdinalAndNameQueryFactory">Handles creation of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</param>
    /// <param name="byOrdinalAndNameQueryHandler">Handles <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</param>
    public GetTypeParameterRepresentationQueryHandler(
        IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory byOrdinalAndNameQueryFactory,
        IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> byOrdinalAndNameQueryHandler)
    {
        ByOrdinalAndNameQueryFactory = byOrdinalAndNameQueryFactory ?? throw new ArgumentNullException(nameof(byOrdinalAndNameQueryFactory));
        ByOrdinalAndNameQueryHandler = byOrdinalAndNameQueryHandler ?? throw new ArgumentNullException(nameof(byOrdinalAndNameQueryHandler));
    }

    ITypeParameterRepresentation IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>.Handle(
        IGetParameterRepresentationQuery<ITypeParameter> query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        var byOrdinalAndNameQuery = ByOrdinalAndNameQueryFactory.Create(query.Parameter.Symbol.Ordinal, query.Parameter.Symbol.Name);

        return ByOrdinalAndNameQueryHandler.Handle(byOrdinalAndNameQuery);
    }
}
