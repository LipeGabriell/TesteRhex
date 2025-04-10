using System.ComponentModel.DataAnnotations;

namespace TesteRhex.Data;

public abstract class Tool
{
    public int Id { get; init; }
    public ToolAddress Address { get; init; }
    public ToolDescription Description { get; init; }
    public ToolDiameter Diameter { get; init; }
    public ToolHeight Height { get; init; }
    public abstract ToolType Type { get; init; }
    public abstract string Path();
}