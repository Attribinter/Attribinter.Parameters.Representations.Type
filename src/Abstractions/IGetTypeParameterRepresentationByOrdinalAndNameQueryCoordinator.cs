namespace Paraminter.Parameters.Representations;

/// <summary>Coordinates creation and handling of <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
/// <typeparam name="TResponse">The type representing the response of the query.</typeparam>
public interface IGetTypeParameterRepresentationByOrdinalAndNameQueryCoordinator<out TResponse>
{
    /// <summary>Creates and handles a <see cref="IGetTypeParameterRepresentationByOrdinalAndNameQuery"/>.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The response of the query.</returns>
    public abstract TResponse Handle(
        int ordinal,
        string name);
}
