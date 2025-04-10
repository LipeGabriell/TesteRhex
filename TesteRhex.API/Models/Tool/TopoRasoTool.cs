namespace TesteRhex.Data;

public class TopoRasoTool : Tool
{
    public ToolType Type { get; init; } = ToolType.TopoRaso;
    public override string Path() => "caminho tradicional";
}