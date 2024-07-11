namespace Paraminter.Parameters.Representations.Type.Queries.Factories.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract IGetTypeParameterRepresentationByOrdinalQuery Sut { get; }

    public abstract int Ordinal { get; }
}
