namespace DocumentationApiPoc.LibraryApi.Infra.Repositories;

public class BookRepository : IBookRepository
{
    private readonly LibraryApiContext _context;

    public BookRepository(LibraryApiContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<BookEntity?>> GetBooksAsync(Guid authorId) =>
        await _context.Books
            .Include(b => b.Author)
            .Where(b => b.AuthorId == authorId)
            .ToListAsync();

    public async Task<BookEntity?> GetBookAsync(Guid authorId, Guid bookId) =>
        await _context.Books
            .Include(b => b.Author)
            .Where(b => b.AuthorId == authorId && b.Id == bookId)
            .FirstOrDefaultAsync();

    public void AddBook(BookEntity bookToAdd) =>
        _context.Add(bookToAdd);

    public async Task<bool> SaveChangesAsync() => 
        await _context.SaveChangesAsync() > 0;
}