namespace Paraminter.Parameters.Representations.Type.Queries.Coordinators;

using Paraminter.Parameters.Representations.Type.Queries.Factories;
using Paraminter.Queries.Coordinators;

using System;

/// <inheritdoc cref="IGetTypeParameterRepresentationByNameQueryCoordinator{TResponse}"/>
public sealed class GetTypeParameterRepresentationByNameQueryCoordinator<TResponse>
    : IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse>
{
    private readonly IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory> DelegatingCoordinator;

    /// <summary>Instantiates a <see cref="IGetTypeParameterRepresentationByNameQueryCoordinator{TResponse}"/>, coordinating creation of handling of <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    /// <param name="delegatingCoordinator">Coordinates creation and handling of queries.</param>
    public GetTypeParameterRepresentationByNameQueryCoordinator(
        IQueryCoordinator<IGetTypeParameterRepresentationByNameQuery, TResponse, IGetTypeParameterRepresentationByNameQueryFactory> delegatingCoordinator)
    {
        DelegatingCoordinator = delegatingCoordinator ?? throw new ArgumentNullException(nameof(delegatingCoordinator));
    }

    TResponse IGetTypeParameterRepresentationByNameQueryCoordinator<TResponse>.Handle(
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return DelegatingCoordinator.Handle(createQuery);

        IGetTypeParameterRepresentationByNameQuery createQuery(
            IGetTypeParameterRepresentationByNameQueryFactory factory)
        {
            return factory.Create(name);
        }
    }
}
