﻿namespace Attribinter.Parameters.Representations;

using Microsoft.Extensions.DependencyInjection;

using System;

/// <summary>Allows the services of <i>Attribinter.Parameters.Representations.Type</i> to be registered with a <see cref="IServiceCollection"/>.</summary>
public static class AttribinterTypeParameterRepresentationsServices
{
    /// <summary>Registers the services of <i>Attribinter.Parameters.Representations.Type</i> with the provided <see cref="IServiceCollection"/>.</summary>
    /// <param name="services">The <see cref="IServiceCollection"/> with which services are registered.</param>
    /// <returns>The provided <see cref="IServiceCollection"/>, so that calls can be chained.</returns>
    public static IServiceCollection AddAttribinterTypeParameterRepresentations(this IServiceCollection services)
    {
        if (services is null)
        {
            throw new ArgumentNullException(nameof(services));
        }

        services.AddTransient<IIndexedAndNamedTypeParameterRepresentationEqualityComparerFactory, IndexedAndNamedTypeParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<IIndexedTypeParameterRepresentationEqualityComparerFactory, IndexedTypeParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<INamedTypeParameterRepresentationEqualityComparerFactory, NamedTypeParameterRepresentationEqualityComparerFactory>();

        services.AddTransient<ITypeParameterRepresentationEqualityComparerFactory, TypeParameterRepresentationEqualityComparerFactory>();
        services.AddTransient<ITypeParameterRepresentationEqualityComparerFactoryProvider, TypeParameterRepresentationEqualityComparerFactoryProvider>();

        services.AddTransient<IIndexedAndNamedTypeParameterRepresentationFactory, IndexedAndNamedTypeParameterRepresentationFactory>();
        services.AddTransient<IIndexedTypeParameterRepresentationFactory, IndexedTypeParameterRepresentationFactory>();
        services.AddTransient<INamedTypeParameterRepresentationFactory, NamedTypeParameterRepresentationFactory>();

        services.AddTransient<ITypeParameterRepresentationFactory, TypeParameterRepresentationFactory>();
        services.AddTransient<ITypeParameterRepresentationFactoryProvider, TypeParameterRepresentationFactoryProvider>();

        return services;
    }
}
