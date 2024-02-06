namespace Simcestry.Common.Domain;

public interface IUnitOfWork
{
	Task Commit();
}