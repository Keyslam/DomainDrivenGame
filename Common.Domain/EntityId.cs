using Simcestry.Common.Domain;

namespace Common.Domain;

public abstract class EntityId : ValueObject<EntityId>
{
	private Guid Value { get; }

	protected EntityId() : this(new Guid())
	{
	}
	
	protected EntityId(Guid value)
	{
		Value = value;
	}

	protected override bool EqualsCore(EntityId other) => Value == other.Value;
	protected override int GetHashCodeCore() => Value.GetHashCode();
}