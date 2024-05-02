namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

internal interface IFactoryFixture
{
    public abstract ITypeParameterRepresentationEqualityComparerFactory Sut { get; }

    public abstract Mock<ITypeParameterRepresentationEqualityComparerFactoryProvider> FactoryProviderMock { get; }
}
