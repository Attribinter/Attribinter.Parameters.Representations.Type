namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class TypeParameterRepresentationFactory
    : IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>
{
    private readonly IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation> ByOrdinalAndNameQueryCoordinator;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="byOrdinalAndNameQueryCoordinator">Handles creation of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</param>
    public TypeParameterRepresentationFactory(
        IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<ITypeParameterRepresentation> byOrdinalAndNameQueryCoordinator)
    {
        ByOrdinalAndNameQueryCoordinator = byOrdinalAndNameQueryCoordinator ?? throw new ArgumentNullException(nameof(byOrdinalAndNameQueryCoordinator));
    }

    ITypeParameterRepresentation IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation>.Handle(
        IGetParameterRepresentationQuery<ITypeParameter> query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return ByOrdinalAndNameQueryCoordinator.Handle(query.Parameter.Symbol.Ordinal, query.Parameter.Symbol.Name);
    }
}
