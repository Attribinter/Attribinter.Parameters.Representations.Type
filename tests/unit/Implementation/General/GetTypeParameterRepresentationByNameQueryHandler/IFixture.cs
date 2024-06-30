namespace Paraminter.Parameters.Representations;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> Sut { get; }
}
