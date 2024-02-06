using Common.Application.Commands;
using Common.Application.Queries;

namespace Common.Application;

public interface IApplicationMediator
{
	Task<TResponse> Handle<TResponse>(IQueryRequest<TResponse> request) where TResponse : IQueryResponse;
	Task<TResponse> HandleQuery<TResponse>(IQueryRequest<TResponse> request) where TResponse : IQueryResponse;

	Task Handle(ICommandRequest request);
	Task HandleCommand(ICommandRequest request);
}