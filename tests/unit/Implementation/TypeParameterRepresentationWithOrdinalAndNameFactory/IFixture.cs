namespace Paraminter.Parameters.Representations;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> Sut { get; }
}
