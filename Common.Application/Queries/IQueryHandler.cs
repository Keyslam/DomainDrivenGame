using MediatR;

namespace Common.Application.Queries;

public interface IQueryHandler<in TQuery, TResponse> : IRequestHandler<TQuery>
	where TQuery : IQueryRequest<TResponse>
	where TResponse : IQueryResponse;