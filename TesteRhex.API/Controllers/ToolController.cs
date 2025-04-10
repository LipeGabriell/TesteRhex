using Microsoft.AspNetCore.Mvc;
using TesteRhex.Data;
using TesteRhexAPI.Repositories.ToolRepository;

namespace TesteRhexAPI.Controllers;

[ApiController]
[Route("api/tool")]
public class ToolController(IToolRepository repository) : Controller
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tool>>> GetAll()
    {
        var tool = await repository.GetAll();
        if (tool == null) return NotFound();
        return Ok(tool);
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<IEnumerable<Tool>>> GetById(int id)
    {
        var tool = await repository.GetById(id);
        if (tool == null) return NotFound();
        return Ok(tool);
    }

    [HttpPost]
    public async Task<ActionResult<IEnumerable<Tool>>> CreateTool(Tool tool)
    {
        var tools = await repository.GetAll();
        if (tools == null) return NotFound();
        if (tools.Contains(tool)) return Ok(tools.First(t => t.Id == tool.Id));
        var createdTool = await repository.Create(tool);
        if (createdTool == null) return NotFound();

        return Ok(tool);
    }

    [HttpDelete("{id:int}")]
    public async Task<ActionResult<IEnumerable<Tool>>> DeleteTool(int id)
    {
        var tool = await repository.GetById(id);
        if (tool == null) return NotFound();
        await repository.Delete(tool);
        return Ok(tool);
    }

    [HttpPut]
    public async Task<ActionResult<IEnumerable<Tool>>> UpdateTool(Tool tool)
    {
        var updatedTool = await repository.GetById(tool.Id);
        if (updatedTool == null) return NotFound();
        await repository.Update(tool);
        return Ok(tool);
    }
}