namespace DocumentationApiPoc.LibraryApi.Shared.InputModels.Queries;

public class GetAuthorQuery : IQuery<GetAuthorsViewModel?>
{
    public Guid AuthorId { get; set; }
}