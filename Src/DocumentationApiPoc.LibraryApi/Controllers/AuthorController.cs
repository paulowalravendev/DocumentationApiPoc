namespace DocumentationApiPoc.LibraryApi.Controllers;

[ApiController]
[Route("authors")]
public class AuthorController : ControllerBase
{
    private readonly ISender _sender;

    public AuthorController(ISender sender)
    {
        _sender = sender;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<GetAuthorsViewModel?>>> GetAuthors() => 
        Ok(await _sender.Send(new GetAuthorsQuery()));

    [HttpGet("{authorId:guid}")]
    public async Task<ActionResult<GetAuthorsViewModel?>> GetAuthor(Guid authorId)
    {
        var result = await _sender.Send(new GetAuthorQuery { AuthorId = authorId });
        if (result is null)
            return NotFound();
        return Ok(result);
    }
}