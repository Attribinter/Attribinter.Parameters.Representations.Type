namespace Paraminter.Parameters.Representations.Type.Queries.Factories;

/// <summary>Handles creation of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
public interface IGetTypeParameterRepresentationByOrdinalAndNameQueryFactory
{
    /// <summary>Creates a <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</returns>
    public abstract IGetTypeParameterRepresentationByOrdinalAndNameQuery Create(
        int ordinal,
        string name);
}
