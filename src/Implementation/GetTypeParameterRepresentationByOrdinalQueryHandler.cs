namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByOrdinalQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>
{
    private readonly ITypeParameterRepresentationWithOrdinalFactory TypeParameterRepresentationFactory;

    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    /// <param name="typeParameterRepresentationFactory">Handles creation of <see cref="ITypeParameterRepresentation"/>.</param>
    public GetTypeParameterRepresentationByOrdinalQueryHandler(
        ITypeParameterRepresentationWithOrdinalFactory typeParameterRepresentationFactory)
    {
        TypeParameterRepresentationFactory = typeParameterRepresentationFactory ?? throw new ArgumentNullException(nameof(typeParameterRepresentationFactory));
    }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByOrdinalQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return TypeParameterRepresentationFactory.Create(query.Ordinal);
    }
}
