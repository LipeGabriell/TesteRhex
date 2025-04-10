using TesteRhex.Contexts;
using TesteRhex.Data;

namespace TesteRhexAPI.Repositories.ToolRepository;

public class ToolRepository(ApplicationDbContext context) : BaseRepository<Tool>(context), IToolRepository
{
}