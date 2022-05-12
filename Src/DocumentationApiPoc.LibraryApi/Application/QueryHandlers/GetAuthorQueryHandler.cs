namespace DocumentationApiPoc.LibraryApi.Application.QueryHandlers;

public class GetAuthorQueryHandler : IQueryHandler<GetAuthorQuery, GetAuthorsViewModel?>
{
    private readonly IMapper _mapper;
    private readonly IAuthorRepository _authorRepository;

    public GetAuthorQueryHandler(IMapper mapper, IAuthorRepository authorRepository)
    {
        _mapper = mapper;
        _authorRepository = authorRepository;
    }

    public async Task<GetAuthorsViewModel?> Handle(GetAuthorQuery request, CancellationToken cancellationToken) => 
        _mapper.Map<GetAuthorsViewModel?>(await _authorRepository.GetAuthorAsync(request.AuthorId));
}