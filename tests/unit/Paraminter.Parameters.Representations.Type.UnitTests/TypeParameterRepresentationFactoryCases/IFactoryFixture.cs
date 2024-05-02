namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract ITypeParameterRepresentationFactory Sut { get; }

    public abstract Mock<ITypeParameterRepresentationFactoryProvider> FactoryProviderMock { get; }
}
