namespace Paraminter.Parameters.Representations.Type.Queries.Factories.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract IGetTypeParameterRepresentationByOrdinalAndNameQuery Sut { get; }

    public abstract int Ordinal { get; }
    public abstract string Name { get; }
}
