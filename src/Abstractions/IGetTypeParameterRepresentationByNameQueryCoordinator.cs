namespace Paraminter.Parameters.Representations;

/// <summary>Coordinates creation and handling of <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
/// <typeparam name="TResponse">The type representing the response of the query.</typeparam>
public interface IGetTypeParameterRepresentationByNameQueryCoordinator<out TResponse>
{
    /// <summary>Creates and handles a <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    /// <param name="name">The name of the type parameter.</param>
    /// <returns>The response of the query.</returns>
    public abstract TResponse Handle(
        string name);
}
