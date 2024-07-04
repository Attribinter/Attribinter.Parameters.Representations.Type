namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract IGetTypeParameterRepresentationByNameQuery Sut { get; }

    public abstract string Name { get; }
}
