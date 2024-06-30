namespace Paraminter.Parameters.Representations.TypeParameterRepresentation;

internal interface IFixture
{
    public abstract ITypeParameterRepresentation Sut { get; }

    public abstract int Ordinal { get; }
    public abstract string Name { get; }
}
