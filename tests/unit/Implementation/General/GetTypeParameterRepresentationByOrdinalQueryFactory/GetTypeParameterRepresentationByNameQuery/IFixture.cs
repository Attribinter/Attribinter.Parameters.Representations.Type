namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract IGetTypeParameterRepresentationByOrdinalQuery Sut { get; }

    public abstract int Ordinal { get; }
}
