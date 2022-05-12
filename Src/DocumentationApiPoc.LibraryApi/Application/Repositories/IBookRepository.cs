namespace DocumentationApiPoc.LibraryApi.Application.Repositories;

public interface IBookRepository
{
    Task<IEnumerable<BookEntity?>> GetBooksAsync(Guid authorId);
    Task<BookEntity?> GetBookAsync(Guid authorId, Guid bookId);
    void AddBook(BookEntity bookToAdd);
    Task<bool> SaveChangesAsync();
}