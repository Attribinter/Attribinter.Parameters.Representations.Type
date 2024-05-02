namespace Paraminter.Parameters.Representations.LoweringTypeParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IIndexedAndNamedTypeParameterRepresentationFactory> InnerFactoryMock { get; }
}
