namespace Paraminter.Parameters.Representations.Type.Queries.Factories.GetTypeParameterRepresentationByNameQuery;

using Xunit;

public sealed class Name
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
        return fixture.Sut.Name;
    }
}
