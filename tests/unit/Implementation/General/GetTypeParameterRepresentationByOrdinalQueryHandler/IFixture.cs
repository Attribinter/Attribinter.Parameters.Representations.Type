namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<ITypeParameterRepresentationWithOrdinalFactory> TypeParameterRepresentationFactoryMock { get; }
}
