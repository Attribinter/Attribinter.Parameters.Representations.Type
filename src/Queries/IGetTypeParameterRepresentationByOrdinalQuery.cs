namespace Paraminter.Parameters.Representations;

/// <summary>Represents a query for a type parameter representation, given the ordinal of the type parameter.</summary>
public interface IGetTypeParameterRepresentationByOrdinalQuery
    : IQuery
{
    /// <summary>The ordinal of the type parameter.</summary>
    public abstract int Ordinal { get; }
}
