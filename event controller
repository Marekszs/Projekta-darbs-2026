[ApiController]
[Route("api/events")]
public class EventsController : ControllerBase
{
    private readonly AppDbContext _context;

    public EventsController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetEvents()
    {
        return Ok(await _context.Events.ToListAsync());
    }

    [Authorize(Roles = "Admin")]
    [HttpPost]
    public async Task<IActionResult> CreateEvent(Event model)
    {
        _context.Events.Add(model);
        await _context.SaveChangesAsync();
        return CreatedAtAction(nameof(GetEvents), new { id = model.Id }, model);
    }
}
