namespace Paraminter.Parameters.Representations.NamedTypeParameterRepresentationEqualityComparerFactoryCases.TypeParameterRepresentationEqualityComparerCases;

using Moq;

using System.Collections.Generic;

internal interface IComparerFixture
{
    public abstract IEqualityComparer<ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}
