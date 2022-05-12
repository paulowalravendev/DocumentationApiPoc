namespace DocumentationApiPoc.LibraryApi.Application.Repositories;

public interface IAuthorRepository
{
    Task<bool> AuthorExistsAsync(Guid authorId);
    Task<IEnumerable<AuthorEntity?>> GetAuthorsAsync();
    Task<AuthorEntity?> GetAuthorAsync(Guid authorId);
    void UpdateAuthor(AuthorEntity author);
    Task<bool> SaveChangesAsync();
}