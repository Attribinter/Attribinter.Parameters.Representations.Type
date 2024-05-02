namespace Paraminter.Parameters.Representations.ParaminterTypeParameterRepresentationsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using System;

using Xunit;

public sealed class AddParaminterTypeParameterRepresentations
{
    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var services = Mock.Of<IServiceCollection>();

        var result = Target(services);

        Assert.Same(services, result);
    }

    [Fact]
    public void IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void IIndexedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void INamedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void ITypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void ITypeParameterRepresentationEqualityComparerFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationEqualityComparerFactoryProvider>();

    [Fact]
    public void IIndexedAndNamedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedAndNamedTypeParameterRepresentationFactory>();

    [Fact]
    public void IIndexedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedTypeParameterRepresentationFactory>();

    [Fact]
    public void INamedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedTypeParameterRepresentationFactory>();

    [Fact]
    public void ITypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationFactory>();

    [Fact]
    public void ITypeParameterRepresentationFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationFactoryProvider>();

    private static IServiceCollection Target(IServiceCollection services) => ParaminterTypeParameterRepresentationsServices.AddParaminterTypeParameterRepresentations(services);

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>()
        where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(static (services) => Target(services));

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);
    }
}
