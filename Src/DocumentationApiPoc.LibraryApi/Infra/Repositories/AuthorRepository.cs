namespace DocumentationApiPoc.LibraryApi.Infra.Repositories;

public class AuthorRepository : IAuthorRepository
{
    private readonly LibraryApiContext _context;

    public AuthorRepository(LibraryApiContext context)
    {
        _context = context;
    }

    public async Task<bool> AuthorExistsAsync(Guid authorId) => 
        await _context.Authors.AnyAsync(a => a.Id == authorId);

    public async Task<IEnumerable<AuthorEntity?>> GetAuthorsAsync() =>
        await _context.Authors.ToListAsync();

    public async Task<AuthorEntity?> GetAuthorAsync(Guid authorId) =>
        await _context.Authors
            .FirstOrDefaultAsync(a => a.Id == authorId);

    public void UpdateAuthor(AuthorEntity author)
    {
        // no code in this implementation
    }

    public async Task<bool> SaveChangesAsync() => 
        await _context.SaveChangesAsync() > 0;
}