namespace TesteRhex.Data;

public class TopoRasoTool : Tool
{
    public override ToolType Type { get; init; } = ToolType.TopoRaso;
    public override string Path()
    {
        return "caminho tradicional";
    }
}