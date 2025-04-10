namespace TesteRhex.Data;

public class VBitTool : Tool
{
    public ToolType Type { get; init; } = ToolType.VBit;
    public override string Path() => "subir nos cantos";
}