namespace Paraminter.Parameters.Representations.TypeParameterRepresentationEqualityComparer;

using Moq;

using System.Collections.Generic;

internal interface IFixture
{
    public abstract IEqualityComparer<ITypeParameterRepresentation> Sut { get; }

    public abstract Mock<IEqualityComparer<string>> NameComparerMock { get; }
}
