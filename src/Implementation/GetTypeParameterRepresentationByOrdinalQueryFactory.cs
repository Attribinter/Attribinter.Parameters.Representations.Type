namespace Paraminter.Parameters.Representations;

/// <inheritdoc cref="IGetTypeParameterRepresentationByOrdinalQueryFactory"/>
public sealed class GetTypeParameterRepresentationByOrdinalQueryFactory
    : IGetTypeParameterRepresentationByOrdinalQueryFactory
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalQueryFactory"/>, handling creation of <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
    public GetTypeParameterRepresentationByOrdinalQueryFactory() { }

    IGetTypeParameterRepresentationByOrdinalQuery IGetTypeParameterRepresentationByOrdinalQueryFactory.Create(
        int ordinal)
    {
        return new GetTypeParameterRepresentationByOrdinalQuery(ordinal);
    }

    private sealed record class GetTypeParameterRepresentationByOrdinalQuery
        : IGetTypeParameterRepresentationByOrdinalQuery
    {
        private readonly int Ordinal;

        public GetTypeParameterRepresentationByOrdinalQuery(
            int ordinal)
        {
            Ordinal = ordinal;
        }

        int IGetTypeParameterRepresentationByOrdinalQuery.Ordinal => Ordinal;
    }
}
