namespace Attribinter.Parameters.Representations;

/// <summary>Represents some type parameter.</summary>
public interface ITypeParameterRepresentation
{
    /// <summary>Indicates whether the index of the type parameter is known.</summary>
    public abstract bool IsIndexKnown { get; }

    /// <summary>Indicates whether the name of the type parameter is known.</summary>
    public abstract bool IsNameKnown { get; }

    /// <summary>Retrieves the index of the type parameter, if known.</summary>
    public abstract int GetIndex();

    /// <summary>Retrieves the name of the type parameter, if known.</summary>
    public abstract string GetName();
}
