namespace DocumentationApiPoc.LibraryApi.Shared.Profiles;

public class AuthorProfile : Profile
{
    public AuthorProfile()
    {
        CreateMap<AuthorEntity, GetAuthorsViewModel>();
    }
}