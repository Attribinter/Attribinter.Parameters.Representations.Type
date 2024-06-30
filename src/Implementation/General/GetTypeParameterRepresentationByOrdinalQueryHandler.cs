namespace Paraminter.Parameters.Representations;

using System;

/// <summary>Handles <see cref="IGetTypeParameterRepresentationByOrdinalQuery"/>, and responds with <see cref="ITypeParameterRepresentation"/>.</summary>
public sealed class GetTypeParameterRepresentationByOrdinalQueryHandler
    : IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>
{
    /// <summary>Instantiates a <see cref="GetTypeParameterRepresentationByOrdinalQueryHandler"/>, handling <see cref="IGetTypeParameterRepresentationByNameQuery"/>.</summary>
    public GetTypeParameterRepresentationByOrdinalQueryHandler() { }

    ITypeParameterRepresentation IQueryHandler<IGetTypeParameterRepresentationByOrdinalQuery, ITypeParameterRepresentation>.Handle(
        IGetTypeParameterRepresentationByOrdinalQuery query)
    {
        if (query is null)
        {
            throw new ArgumentNullException(nameof(query));
        }

        return new TypeParameterRepresentation(query.Ordinal);
    }

    private sealed class TypeParameterRepresentation
        : ITypeParameterRepresentation
    {
        private readonly int Ordinal;

        public TypeParameterRepresentation(
            int ordinal)
        {
            Ordinal = ordinal;
        }

        bool ITypeParameterRepresentation.IsOrdinalKnown => true;
        bool ITypeParameterRepresentation.IsNameKnown => false;

        int ITypeParameterRepresentation.GetOrdinal() => Ordinal;
        string ITypeParameterRepresentation.GetName() => throw new InvalidOperationException("Cannot retrieve the name of the represented type parameter, as it is not known.");
    }
}
