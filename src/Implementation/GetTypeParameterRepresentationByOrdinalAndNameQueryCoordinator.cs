namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator{TResponse}"/>
public sealed class GetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse>
    : IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse>
{
    private readonly IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> DelegatingCoordinator;

    /// <summary>Instantiates a <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator{TResponse}"/>, coordinating creation of handling of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    /// <param name="delegatingCoordinator">Coordinates creation and handling of queries.</param>
    public GetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator(
        IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalAndNameQuery, TResponse, IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> delegatingCoordinator)
    {
        DelegatingCoordinator = delegatingCoordinator ?? throw new ArgumentNullException(nameof(delegatingCoordinator));
    }

    TResponse IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<TResponse>.Handle(
        int ordinal,
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return DelegatingCoordinator.Handle(createQuery);

        IGetTypeParameterRepresentationByOrdinalAndNameQuery createQuery(
            IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory factory)
        {
            return factory.Create(ordinal, name);
        }
    }
}
