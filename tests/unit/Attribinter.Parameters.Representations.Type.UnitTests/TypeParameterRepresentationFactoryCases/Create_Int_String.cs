namespace Attribinter.Parameters.Representations.TypeParameterRepresentationFactoryCases;

using Moq;

using System;

using Xunit;

public sealed class Create_Int_String
{
    private ITypeParameterRepresentation Target(int index, string name) => Fixture.Sut.Create(index, name);

    private readonly IFactoryFixture Fixture = FactoryFixtureFactory.Create();

    [Fact]
    public void NullName_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(0, null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidIndexAndName_ReturnsRepresentation()
    {
        var index = 42;
        var name = "Name";

        var representation = Mock.Of<ITypeParameterRepresentation>();

        Fixture.FactoryProviderMock.Setup((provider) => provider.IndexedAndNamedFactory.Create(index, name)).Returns(representation);

        var result = Target(index, name);

        Assert.Equal(representation, result);
    }
}
