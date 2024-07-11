namespace Paraminter.Parameters.Representations.Type.Queries.Factories.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract IGetTypeParameterRepresentationByNameQuery Sut { get; }

    public abstract string Name { get; }
}
