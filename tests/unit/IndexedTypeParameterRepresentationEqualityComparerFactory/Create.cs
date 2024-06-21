namespace Paraminter.Parameters.Representations;

using System.Collections.Generic;

using Xunit;

public sealed class Create
{
    private readonly IFixture Fixture = FixtureFactory.Create();

    [Fact]
    public void ReturnsComparer()
    {
        var result = Target();

        Assert.NotNull(result);
    }

    private IEqualityComparer<ITypeParameterRepresentation> Target() => Fixture.Sut.Create();
}
