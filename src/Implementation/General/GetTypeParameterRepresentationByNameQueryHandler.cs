namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByNameQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByNameQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByNameQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    public GetTypeParameterRepresentationByNameQueryHandler() { }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByNameQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByNameQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new TypeParameterRepresentation(query.Name);
    }

    private sealed class TypeParameterRepresentation
        : ITypeParameterRepresentation
    {
        private readonly string Name;

        public TypeParameterRepresentation(
            string name)
        {
            Name = name;
        }

        bool ITypeParameterRepresentation.IsOrdinalKnown => false;
        bool ITypeParameterRepresentation.IsNameKnown => true;

        int ITypeParameterRepresentation.GetOrdinal() => throw new InvalidOperationException("Cannot retrieve the ordinal of the represented type parameter, as it is not known.");
        string ITypeParameterRepresentation.GetName() => Name;
    }
}
