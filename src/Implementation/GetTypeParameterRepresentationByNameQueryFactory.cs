namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IGetTypeParameterRepresentationByNameQueryFactory"/>
public sealed class GetTypeParameterRepresentationByNameQueryFactory
    : IGetTypeParameterRepresentationByNameQueryFactory
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByNameQueryFactory"/>, handling creation of <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    public GetTypeParameterRepresentationByNameQueryFactory() { }

    IGetTypeParameterRepresentationByNameQuery IGetTypeParameterRepresentationByNameQueryFactory.Create(
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new GetTypeParameterRepresentationByNameQuery(name);
    }

    private sealed record class GetTypeParameterRepresentationByNameQuery
        : IGetTypeParameterRepresentationByNameQuery
    {
        private readonly string Name;

        public GetTypeParameterRepresentationByNameQuery(
            string name)
        {
            Name = name;
        }

        string IGetTypeParameterRepresentationByNameQuery.Name => Name;
    }
}
