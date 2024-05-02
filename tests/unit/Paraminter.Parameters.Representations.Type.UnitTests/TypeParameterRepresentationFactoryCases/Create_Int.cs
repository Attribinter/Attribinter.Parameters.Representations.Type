namespace Paraminter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using Xunit;

public sealed class Create_Int
{
    private ITypeParameterRepresentation Target(int index) => Fixture.Sut.Create(index);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void ReturnsRepresentation()
    {
        var index = 42;

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Fixture.FactoryProviderMock.Setup((provider) => provider.IndexedFactory.Create(index)).Returns(representation);

        var result = Target(index);

        Assert.Equal(representation, result);
    }
}
