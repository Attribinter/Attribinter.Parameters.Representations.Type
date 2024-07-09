namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IGetTypeParameterRepresentationByOrdinalQueryCoordinator{TResponse}"/>
public sealed class GetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse>
    : IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse>
{
    private readonly IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory> DelegatingCoordinator;

    /// <summary>Instantiates a <see cref="IGetTypeParameterRepresentationByOrdinalQueryCoordinator{TResponse}"/>, coordinating creation of handling of <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
    /// <param name="delegatingCoordinator">Coordinates creation and handling of queries.</param>
    public GetTypeParameterRepresentationByOrdinalQueryCoordinator(
        IQueryCoordinator<IGetTypeParameterRepresentationByOrdinalQuery, TResponse, IGetTypeParameterRepresentationByOrdinalQueryFactory> delegatingCoordinator)
    {
        DelegatingCoordinator = delegatingCoordinator ?? throw new ArgumentNullException(nameof(delegatingCoordinator));
    }

    TResponse IGetTypeParameterRepresentationByOrdinalQueryCoordinator<TResponse>.Handle(
        int ordinal)
    {
        return DelegatingCoordinator.Handle(createQuery);

        IGetTypeParameterRepresentationByOrdinalQuery createQuery(
            IGetTypeParameterRepresentationByOrdinalQueryFactory factory)
        {
            return factory.Create(ordinal);
        }
    }
}
