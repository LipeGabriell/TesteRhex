namespace TesteRhex.Data;

public class ToolDescription
{
    private string Value { get; }

    public ToolDescription(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
            throw new ArgumentException("Descrição deve conter no mínimo 3 caracteres.");
        Value = value;
    }

    public override string ToString() => Value;
}