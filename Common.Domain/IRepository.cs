namespace Common.Domain;

public interface IRepository<TAggregateRoot, in TId> 
	where TAggregateRoot : AggregateRoot<TId>
	where TId : EntityId
{
	public Task<TAggregateRoot?> GetById(TId id);
	
	public void Insert(TAggregateRoot aggregateRoot);
	public void Delete(TAggregateRoot aggregateRoot);
}