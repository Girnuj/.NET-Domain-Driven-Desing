namespace Wpm.SharedKernel;

public abstract class Entity : IEquatable<Entity>
{
    public Guid Id { get; init; }
    public bool Equals(Entity? other) => other?.Id == Id;
    public override bool Equals(object obj) => Equals(obj as Entity);
    public override int GetHashCode() => Id.GetHashCode();
    public static bool operator ==(Entity? left, Entity? right) => left?.Id == right?.Id;
    public static bool operator !=(Entity? left, Entity? right) => left?.Id != right?.Id;
}
