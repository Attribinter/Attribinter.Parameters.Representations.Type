namespace Paraminter.Parameters.Representations.Type;

using Paraminter.Parameters.Representations.Queries;
using Paraminter.Parameters.Representations.Type.Common;
using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Parameters.Type;
using Paraminter.Queries.Handlers;

using System;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class TypeParameterRepresentationFactory
    : IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>
{
    private readonly IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> ByOrdinalAndNameQueryHandler;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="byOrdinalAndNameQueryHandler">Handles <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</param>
    public TypeParameterRepresentationFactory(
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

        return CreateAndHandleByOrdinalAndNameQuery(query.Parameter.Symbol.Ordinal, query.Parameter.Symbol.Name);
    }

    private ITypeParameterRepresentation CreateAndHandleByOrdinalAndNameQuery(
        int ordinal,
        string name)
    {
        var query = GetTypeParameterRepresentationByOrdinalAndNameQueryFactory.Create(ordinal, name);

        return ByOrdinalAndNameQueryHandler.Handle(query);
    }
}
