namespace Attribinter.Parameters.Representations.AttribinterMapperCollectorsServicesCases;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Moq;

using System;

using Xunit;

public sealed class AddAttribinterTypeParameterRepresentations
{
    private static IServiceCollection Target(IServiceCollection services) => AttribinterTypeParameterRepresentationsServices.AddAttribinterTypeParameterRepresentations(services);

    [Fact]
    public void NullServiceCollection_ArgumentNullException()
    {
        var result = Record.Exception(() => Target(null!));

        Assert.IsType<ArgumentNullException>(result);
    }

    [Fact]
    public void ValidServiceCollection_ReturnsSameServiceCollection()
    {
        var serviceCollection = Mock.Of<IServiceCollection>();

        var result = Target(serviceCollection);

        Assert.Same(serviceCollection, result);
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

    [AssertionMethod]
    private static void ServiceCanBeResolved<TService>() where TService : notnull
    {
        HostBuilder host = new();

        host.ConfigureServices(configureServices);

        var serviceProvider = host.Build().Services;

        var result = serviceProvider.GetRequiredService<TService>();

        Assert.NotNull(result);

        static void configureServices(IServiceCollection services) => Target(services);
    }
}
