namespace DocumentationApiPoc.LibraryApi.Application.QueryHandlers;

public interface IQueryHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
}