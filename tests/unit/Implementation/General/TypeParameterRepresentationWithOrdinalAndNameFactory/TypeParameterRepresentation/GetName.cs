namespace Paraminter.Parameters.Representations.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class GetName
{
    [Fact]
    public void ReturnsName()
    {
        var fixture = FixtureFactory.Create(42, "Name");

        var result = Target(fixture);

        Assert.Equal(fixture.Name, result);
    }

    private static string Target(
        IFixture fixture)
    {
        return fixture.Sut.GetName();
    }
}
