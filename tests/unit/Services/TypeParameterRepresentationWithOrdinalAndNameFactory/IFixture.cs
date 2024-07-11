namespace Paraminter.Parameters.Representations.Type;

using Paraminter.Parameters.Representations.Type.Queries;
using Paraminter.Queries.Handlers;

internal interface IFixture
{
    public abstract IQueryHandler<IGetTypeParameterRepresentationByOrdinalAndNameQuery, ITypeParameterRepresentation> Sut { get; }
}
