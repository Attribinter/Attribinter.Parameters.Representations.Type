namespace Attribinter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System;
using System.Collections.Generic;

using Xunit;

public sealed class Create
{
    private static IEqualityComparer<ITypeParameterRepresentation> Target(IEqualityComparer<string> nameComparer) => Context.Factory.Create(nameComparer);

    private static readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void NullNameComparer_ThrowsArgumentNullException()
    {
        var exception = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(exception);
    }

    [Fact]
    public void ValidNameComparer_ReturnsNotNull()
    {
        var actual = Target(Mock.Of<IEqualityComparer<string>>());

        Assert.NotNull(actual);
    }
}
