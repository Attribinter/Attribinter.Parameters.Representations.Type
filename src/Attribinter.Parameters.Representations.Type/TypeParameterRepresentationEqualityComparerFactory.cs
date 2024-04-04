namespace Attribinter.Parameters.Representations;

using System;
using System.Collections.Generic;

/// <inheritdoc cref="ITypeParameterRepresentationEqualityComparerFactory"/>
public sealed class TypeParameterRepresentationEqualityComparerFactory : ITypeParameterRepresentationEqualityComparerFactory
{
    private readonly ITypeParameterRepresentationEqualityComparerFactoryProvider FactoryProvider;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationEqualityComparerFactory"/>, handling creation of comparers of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="factoryProvider">Provides factories of comparers of <see cref="ITypeParameterRepresentation"/>.</param>
    public TypeParameterRepresentationEqualityComparerFactory(ITypeParameterRepresentationEqualityComparerFactoryProvider factoryProvider)
    {
        FactoryProvider = factoryProvider ?? throw new ArgumentNullException(nameof(factoryProvider));
    }

    IEqualityComparer<ITypeParameterRepresentation> ITypeParameterRepresentationEqualityComparerFactory.CreateIndexedAndNamed(IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return FactoryProvider.IndexedAndNamedFactory.Create(nameComparer);
    }

    IEqualityComparer<ITypeParameterRepresentation> ITypeParameterRepresentationEqualityComparerFactory.CreateIndexed() => FactoryProvider.IndexedFactory.Create();

    IEqualityComparer<ITypeParameterRepresentation> ITypeParameterRepresentationEqualityComparerFactory.CreateNamed(IEqualityComparer<string> nameComparer)
    {
        if (nameComparer is null)
        {
            throw new ArgumentNullException(nameof(nameComparer));
        }

        return FactoryProvider.NamedFactory.Create(nameComparer);
    }
}
