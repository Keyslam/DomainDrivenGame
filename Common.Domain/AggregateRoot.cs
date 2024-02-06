using Simcestry.Common.Domain;

namespace Common.Domain;

public abstract class AggregateRoot<TId> : Entity<TId> where TId : EntityId
{
	protected AggregateRoot(TId id) : base(id)
	{
	}
};