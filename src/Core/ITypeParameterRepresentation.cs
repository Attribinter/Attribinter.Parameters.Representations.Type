namespace Paraminter.Parameters.Representations.Type;

/// <summary>Represents a type parameter.</summary>
public interface ITypeParameterRepresentation
{
    /// <summary>Indicates whether the ordinal of the type parameter is known.</summary>
    public abstract bool IsOrdinalKnown { get; }

    /// <summary>Indicates whether the name of the type parameter is known.</summary>
    public abstract bool IsNameKnown { get; }

    /// <summary>Retrieves the ordinal of the type parameter, if known.</summary>
    /// <returns>The ordinal of the type parameter, if known.</returns>
    public abstract int GetOrdinal();

    /// <summary>Retrieves the name of the type parameter, if known.</summary>
    /// <returns>The name of the type parameter, if known.</returns>
    public abstract string GetName();
}
