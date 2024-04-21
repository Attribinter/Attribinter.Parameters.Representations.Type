namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create_String
{
    private ITypeParameterRepresentation Target(string name) => Fixture.Sut.Create(name);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidName_ReturnsRepresentation()
    {
        var name = "Name";

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Fixture.FactoryProviderMock.Setup((provider) => provider.NamedFactory.Create(name)).Returns(representation);

        var result = Target(name);

        Assert.Equal(representation, result);
    }
}
