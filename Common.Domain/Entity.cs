using System.Collections.ObjectModel;
using Simcestry.Common.Domain;

namespace Common.Domain;

public abstract class Entity<TId> where TId : EntityId
{
	private readonly TId _id;

	private Collection<IDomainEvent>? _domainEvents = null;
	public IReadOnlyCollection<IDomainEvent>? DomainEvents => _domainEvents;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
	protected Entity() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

	protected Entity(TId id)
	{
		_id = id;
	}
	
	protected void RaiseDomainEvent(IDomainEvent domainEvent)
	{
		_domainEvents ??= [];
		_domainEvents.Add(domainEvent);
	}
	
	public override bool Equals(object? obj)
	{
		if (obj is not Entity<TId> entity)
			return false;
 
		return _id == entity._id;
	}

	public override int GetHashCode()
	{
		return _id.GetHashCode();
	}

	public static bool operator ==(Entity<TId> a, Entity<TId> b)
	{
		if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
			return true;
 
		if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
			return false;
 
		return a.Equals(b);
	}
 
	public static bool operator !=(Entity<TId> a, Entity<TId> b)
	{
		return !(a == b);
	}
}