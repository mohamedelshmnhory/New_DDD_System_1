namespace New_Sytem.Domain.core.BaseType;

public abstract class Entity
{
    protected Entity(Guid id) => Id = id;

    protected Entity() { }

    public Guid Id { get; }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
