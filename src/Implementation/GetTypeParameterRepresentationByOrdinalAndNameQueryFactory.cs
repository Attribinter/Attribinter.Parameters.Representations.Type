namespace Paraminter.Parameters.Representations;

using System;

/// <inheritdoc cref="IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory"/>
public sealed class GetTypeParameterRepresentationByOrdinalAndNameQueryFactory
    : IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalAndNameQueryFactory"/>, handling creation of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    public GetTypeParameterRepresentationByOrdinalAndNameQueryFactory() { }

    IGetTypeParameterRepresentationByOrdinalAndNameQuery IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory.Create(
        int ordinal,
        string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return new GetTypeParameterRepresentationByOrdinalAndNameQuery(ordinal, name);
    }

    private sealed record class GetTypeParameterRepresentationByOrdinalAndNameQuery
        : IGetTypeParameterRepresentationByOrdinalAndNameQuery
    {
        private readonly int Ordinal;
        private readonly string Name;

        public GetTypeParameterRepresentationByOrdinalAndNameQuery(
            int ordinal,
            string name)
        {
            Ordinal = ordinal;
            Name = name;
        }

        int IGetTypeParameterRepresentationByOrdinalAndNameQuery.Ordinal => Ordinal;
        string IGetTypeParameterRepresentationByOrdinalAndNameQuery.Name => Name;
    }
}
