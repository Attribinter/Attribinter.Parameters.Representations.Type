namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles creation of <see cref="ITypeParameterRepresentation"/> using <see cref="ITypeParameter"/>.</summary>
public sealed class LoweringTypeParameterRepresentationFactory
    : IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation>
{
    private readonly IIndexedAndNamedTypeParameterRepresentationFactory InnerFactory;

    /// <summary>Instantiates a <see cref="LoweringTypeParameterRepresentationFactory"/>, handling creation of <see cref="ITypeParameterRepresentation"/> using <see cref="ITypeParameter"/>.</summary>
    /// <param name="innerFactory">Handles creation of <see cref="ITypeParameterRepresentation"/> using the indices and names of type parameters.</param>
    public LoweringTypeParameterRepresentationFactory(
        IIndexedAndNamedTypeParameterRepresentationFactory innerFactory)
    {
        InnerFactory = innerFactory ?? throw new ArgumentNullException(nameof(innerFactory));
    }

    ITypeParameterRepresentation IParameterRepresentationFactory<ITypeParameter, ITypeParameterRepresentation>.Create(
        ITypeParameter parameter)
    {
        if (parameter is null)
        {
            throw new ArgumentNullException(nameof(parameter));
        }

        return InnerFactory.Create(parameter.Symbol.Ordinal, parameter.Symbol.Name);
    }
}
