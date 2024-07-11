namespace Paraminter.Parameters.Representations.Type.GetTypeParameterRepresentationByNameQuery;

internal interface IFixture
{
    public abstract ITypeParameterRepresentation Sut { get; }

    public abstract string Name { get; }
}
