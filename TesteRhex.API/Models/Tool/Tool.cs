using System.ComponentModel.DataAnnotations;

namespace TesteRhex.Data;

public class Tool
{
    [Key] public int Id { get; init; }

    [Length(1, 50)] public required string Address { get; init; }

    [MinLength(3)] public required string Description { get; init; }

    [Range(0, 100, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public required double Diameter { get; init; }

    [Range(0, 100, MinimumIsExclusive = true, MaximumIsExclusive = true)]
    public double Height { get; init; }

    public virtual ToolType Type { get; init; }

    public virtual string Path() => "não definido";


}