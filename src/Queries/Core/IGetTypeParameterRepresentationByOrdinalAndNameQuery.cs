namespace Paraminter.Parameters.Representations.Type.Queries;

using Paraminter.Queries;

/// <summary>Represents a query for a type parameter representation, given the ordinal and name of the type parameter.</summary>
public interface IGetTypeParameterRepresentationByOrdinalAndNameQuery
    : IQuery
{
    /// <summary>The ordinal of the type parameter.</summary>
    public abstract int Ordinal { get; }

    /// <summary>The name of the type parameter.</summary>
    public abstract string Name { get; }
}
