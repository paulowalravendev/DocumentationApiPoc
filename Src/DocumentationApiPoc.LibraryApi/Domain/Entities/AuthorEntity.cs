namespace DocumentationApiPoc.LibraryApi.Domain.Entities;

[Table("Authors")]
public class AuthorEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string FirstName { get; set; }
    [Required]
    [MaxLength(150)]
    public string LastName { get; set; }
    public ICollection<BookEntity> Books { get; set; } = new List<BookEntity>();
}