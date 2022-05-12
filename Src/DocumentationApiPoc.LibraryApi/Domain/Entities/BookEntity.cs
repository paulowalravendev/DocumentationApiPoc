namespace DocumentationApiPoc.LibraryApi.Domain.Entities;

[Table("Books")]
public class BookEntity
{
    [Key]
    public Guid Id { get; set; }
    [Required]
    [MaxLength(150)]
    public string Title { get; set; }
    [MaxLength(2500)]
    public string Description { get; set; }
    public int? AmountOfPages { get; set; }
    public Guid AuthorId { get; set; }
    public AuthorEntity Author { get; set; }
}