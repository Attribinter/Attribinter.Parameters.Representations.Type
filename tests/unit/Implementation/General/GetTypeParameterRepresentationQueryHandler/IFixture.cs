namespace Paraminter.Parameters.Representations;

using Moq;

internal interface IFixture
{
    public abstract IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory> ByOrdinalAndNameQueryFactoryMock { get; }
    public abstract Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> ByOrdinalAndNameQueryHandlerMock { get; }
}
