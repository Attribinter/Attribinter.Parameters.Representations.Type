namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<ITypeParameterRepresentationWithNameFactory> TypeParameterRepresentationFactoryMock { get; }
}
