using MediatR;

namespace Common.Application.Queries;

public interface IQueryRequest<out TResponse> : IRequest, IRequest<TResponse> where TResponse : IQueryResponse;