namespace Attribinter.Parameters.Representations;

using System;

/// <inheritdoc cref="ITypeParameterRepresentationFactory"/>
public sealed class TypeParameterRepresentationFactory : ITypeParameterRepresentationFactory
{
    private readonly ITypeParameterRepresentationFactoryProvider FactoryProvider;

    /// <summary>Instantiates a <see cref="TypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/>.</summary>
    /// <param name="factoryProvider">Provides factories of <see cref="ITypeParameterRepresentation"/>.</param>
    public TypeParameterRepresentationFactory(ITypeParameterRepresentationFactoryProvider factoryProvider)
    {
        FactoryProvider = factoryProvider ?? throw new ArgumentNullException(nameof(factoryProvider));
    }

    ITypeParameterRepresentation ITypeParameterRepresentationFactory.Create(int index, string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return FactoryProvider.IndexedAndNamedFactory.Create(index, name);
    }

    ITypeParameterRepresentation ITypeParameterRepresentationFactory.Create(int index) => FactoryProvider.IndexedFactory.Create(index);

    ITypeParameterRepresentation ITypeParameterRepresentationFactory.Create(string name)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        return FactoryProvider.NamedFactory.Create(name);
    }
}
