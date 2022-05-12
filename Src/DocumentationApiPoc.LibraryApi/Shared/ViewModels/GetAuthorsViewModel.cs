namespace DocumentationApiPoc.LibraryApi.Shared.ViewModels;

public class GetAuthorsViewModel : IViewModel
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
}