namespace Attribinter.Parameters.Representations.IndexedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using System.Collections.Generic;

internal interface IComparerFixture
{
    public abstract IEqualityComparer<ITypeParameterRepresentation> Sut { get; }
}
