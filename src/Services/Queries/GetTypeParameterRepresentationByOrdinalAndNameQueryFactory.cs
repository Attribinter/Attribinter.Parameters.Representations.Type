namespace Paraminter.Parameters.Representations.Type.Queries;

internal static class GetTypeParameterRepresentationByOrdinalAndNameQueryFactory
{
    public static IGetTypeParameterRepresentationByOrdinalAndNameQuery Create(
        int ordinal,
        string name)
    {
        return new GetTypeParameterRepresentationByOrdinalAndNameQuery(ordinal, name);
    }

    private sealed class GetTypeParameterRepresentationByOrdinalAndNameQuery
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
