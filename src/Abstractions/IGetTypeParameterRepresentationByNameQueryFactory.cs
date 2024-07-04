namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
public interface IGetTypeParameterRepresentationByNameQueryFactory
{
    /// <summary>Creates a <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The created <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</returns>
    public abstract IGetTypeParameterRepresentationByNameQuery Create(
        string name);
}
