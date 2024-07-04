namespace Paraminter.Parameters.Representations;

/// <summary>Handles creation of <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
public interface IGetTypeParameterRepresentationByOrdinalQueryFactory
{
    /// <summary>Creates a <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <returns>The created <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</returns>
    public abstract IGetTypeParameterRepresentationByOrdinalQuery Create(
        int ordinal);
}
