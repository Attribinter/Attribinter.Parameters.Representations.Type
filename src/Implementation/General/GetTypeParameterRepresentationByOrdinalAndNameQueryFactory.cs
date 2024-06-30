namespace Paraminter.Parameters.Representations;

internal static class GetTypeParameterRepresentationByOrdinalAndNameQueryFactory
{
    public static IGetTypeParameterRepresentationByOrdinalAndNameQuery FromParameter(
        ITypeParameter parameter)
    {
        return new GetTypeParameterRepresentationByOrdinalAndNameQuery(parameter.Symbol.Ordinal, parameter.Symbol.Name);
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
