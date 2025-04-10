namespace TesteRhex.Data;

public class VBitTool : Tool
{
    public override ToolType Type { get; init; } = ToolType.VBit;
    public override string Path()
    {
        return "subir nos cantos";
    }
}