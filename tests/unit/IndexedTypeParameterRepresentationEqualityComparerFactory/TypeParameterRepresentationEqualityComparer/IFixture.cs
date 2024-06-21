namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparer;

using System.Collections.Generic;

internal interface IFixture
{
    public abstract IEqualityComparer<ITypeParameterRepresentation> Sut { get; }
}
