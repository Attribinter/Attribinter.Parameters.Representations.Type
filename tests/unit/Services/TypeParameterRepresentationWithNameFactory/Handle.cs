namespace Paraminter.Parameters.Representations.Type;

using Moq;

using Paraminter.Parameters.Representations.Type.Queries;

using System;

using Xunit;

public sealed class Handle
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void NullQuery_ThrowsArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidQuery_ReturnsRepresentation()
    {
        var result = Target(Mock.Of<IGetTypeParameterRepresentationByNameQuery>());

        Assert.NotNull(result);
    }

    private ITypeParameterRepresentation Target(
        IGetTypeParameterRepresentationByNameQuery query)
    {
        return Fixture.Sut.Handle(query);
    }
}
