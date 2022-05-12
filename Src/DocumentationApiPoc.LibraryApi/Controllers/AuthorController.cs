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
    public async Task<ActionResult<IEnumerable<GetAuthorsViewModel>>> GetAuthors() => 
        Ok(await _sender.Send(new GetAuthorsQuery()));
}