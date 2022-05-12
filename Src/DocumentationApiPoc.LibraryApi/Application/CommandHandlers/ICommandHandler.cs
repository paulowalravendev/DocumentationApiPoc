namespace DocumentationApiPoc.LibraryApi.Application.CommandHandlers;

public interface ICommandHandler<in TRequest, TResponse> : IRequestHandler<TRequest, TResponse> where TRequest : IRequest<TResponse>
{
}