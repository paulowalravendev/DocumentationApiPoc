namespace DocumentationApiPoc.LibraryApi.Shared.InputModels.Queries;

public interface IQuery<out TResponse> : IRequest<TResponse>
{
}