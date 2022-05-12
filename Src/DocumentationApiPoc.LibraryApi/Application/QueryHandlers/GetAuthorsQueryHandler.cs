namespace DocumentationApiPoc.LibraryApi.Application.QueryHandlers;

public class GetAuthorsQueryHandler : IQueryHandler<GetAuthorsQuery, IEnumerable<GetAuthorsViewModel?>>
{
    private readonly IMapper _mapper;
    private readonly IAuthorRepository _authorRepository;

    public GetAuthorsQueryHandler(IMapper mapper, IAuthorRepository authorRepository)
    {
        _mapper = mapper;
        _authorRepository = authorRepository;
    }

    public async Task<IEnumerable<GetAuthorsViewModel?>> Handle(GetAuthorsQuery request,
        CancellationToken cancellationToken) =>
        _mapper.Map<IEnumerable<GetAuthorsViewModel?>>(await _authorRepository.GetAuthorsAsync());
}