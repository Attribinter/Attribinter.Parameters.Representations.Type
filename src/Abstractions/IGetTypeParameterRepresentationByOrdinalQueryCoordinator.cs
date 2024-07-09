namespace Paraminter.Parameters.Representations;

/// <summary>Coordinates creation and handling of <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
/// <typeparam name="TResponse">The type representing the response of the query.</typeparam>
public interface IGetTypeParameterRepresentationByOrdinalQueryCoordinator<out TResponse>
{
    /// <summary>Creates and handles a <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>.</summary>
    /// <param name="ordinal">The ordinal of the type parameter.</param>
    /// <returns>The response of the query.</returns>
    public abstract TResponse Handle(
        int ordinal);
}
