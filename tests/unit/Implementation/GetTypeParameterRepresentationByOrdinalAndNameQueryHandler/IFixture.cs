namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<ITypeParameterRepresentationWithOrdinalAndNameFactory> TypeParameterRepresentationFactoryMock { get; }
}
