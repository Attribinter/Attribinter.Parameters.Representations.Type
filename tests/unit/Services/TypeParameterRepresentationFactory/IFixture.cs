namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Queries;
using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Parameters.Type;
using Paraminter.Queries.Handlers;

internal interface IFixture
{
    public abstract IQueryHandler<IGetParameterRepresentationQuery<ITypeParameter>, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation>> ByOrdinalAndNameQueryHandlerMock { get; }
}
