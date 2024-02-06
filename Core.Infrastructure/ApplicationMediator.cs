using Common.Application;
using Common.Application.Commands;
using Common.Application.Queries;
using MediatR;

namespace Core.Infrastructure;

internal sealed class ApplicationMediator(ISender mediator) : IApplicationMediator
{
	public Task<TResponse> Handle<TResponse>(IQueryRequest<TResponse> request) where TResponse : IQueryResponse => throw new NotImplementedException();
	public Task<TResponse> HandleQuery<TResponse>(IQueryRequest<TResponse> request) where TResponse : IQueryResponse => Handle(request);

	public Task Handle(ICommandRequest request) => mediator.Send(request);
	public Task HandleCommand(ICommandRequest request) => Handle(request);
}