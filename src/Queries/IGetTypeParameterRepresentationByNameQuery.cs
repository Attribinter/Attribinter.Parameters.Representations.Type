namespace Paraminter.Parameters.Representations;

/// <summary>Represents a query for a type parameter representation, given the name of the type parameter.</summary>
public interface IGetTypeParameterRepresentationByNameQuery
    : IQuery
{
    /// <summary>The name of the type parameter.</summary>
    public abstract string Name { get; }
}
