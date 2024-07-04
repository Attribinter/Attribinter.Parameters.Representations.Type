namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByNameQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation>
{
    private readonly ITypeParameterRepresentationWithNameFactory TypeParameterRepresentationFactory;

    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByNameQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    /// <param name="typeParameterRepresentationFactory">Handles creation of <see cref="ITypeParameterRepresentation"/>.</param>
    public GetTypeParameterRepresentationByNameQueryHandler(
        ITypeParameterRepresentationWithNameFactory typeParameterRepresentationFactory)
    {
        TypeParameterRepresentationFactory = typeParameterRepresentationFactory ?? throw new ArgumentNullException(nameof(typeParameterRepresentationFactory));
    }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return TypeParameterRepresentationFactory.Create(query.Name);
    }
}
