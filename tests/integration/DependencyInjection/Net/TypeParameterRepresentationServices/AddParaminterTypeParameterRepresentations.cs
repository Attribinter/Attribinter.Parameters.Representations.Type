namespace Paraminter.Parameters.Representations;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using Xunit;

public sealed class AddParaminterTypeParameterRepresentations
{
    [Fact]
    public void IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void IIndexedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void INamedTypeParameterRepresentationEqualityComparerFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedTypeParameterRepresentationEqualityComparerFactory>();

    [Fact]
    public void ITypeParameterRepresentationEqualityComparerFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationEqualityComparerFactoryProvider>();

    [Fact]
    public void IIndexedAndNamedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedAndNamedTypeParameterRepresentationFactory>();

    [Fact]
    public void IIndexedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IIndexedTypeParameterRepresentationFactory>();

    [Fact]
    public void INamedTypeParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<INamedTypeParameterRepresentationFactory>();

    [Fact]
    public void ITypeParameterRepresentationFactoryProvider_ServiceCanBeResolved() => ServiceCanBeResolved<ITypeParameterRepresentationFactoryProvider>();

    [Fact]
    public void IParameterRepresentationFactory_ServiceCanBeResolved() => ServiceCanBeResolved<IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation>>();

    private static void Target(
        IServiceCollection services)
    {
        TypeParameterRepresentationServices.AddParaminterTypeParameterRepresentations(services);
    }

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
