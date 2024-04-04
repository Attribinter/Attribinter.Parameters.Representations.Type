namespace Attribinter.Parameters.Representations.TypeParameterRepresentationEqualityComparerFactoryCases;

using Moq;

using System.Collections.Generic;

using Xunit;

public sealed class CreateIndexed
{
    private IEqualityComparer<ITypeParameterRepresentation> Target() => Context.Factory.CreateIndexed();

    private readonly FactoryContext Context = FactoryContext.Create();

    [Fact]
    public void ReturnsComparer()
    {
        var comparer = Mock.Of<IEqualityComparer<ITypeParameterRepresentation>>();

        Context.FactoryProviderMock.Setup(static (provider) => provider.IndexedFactory.Create()).Returns(comparer);

        var actual = Target();

        Assert.Equal(comparer, actual);

        Context.FactoryProviderMock.Verify(static (provider) => provider.IndexedFactory.Create(), Times.Once());
        Context.FactoryProviderMock.VerifyNoOtherCalls();
    }
}
