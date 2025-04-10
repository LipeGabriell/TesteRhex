namespace TesteRhex.Data;

public class ToolAddress
{
    private string Value { get; }

    public ToolAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || value.Length < 1 || value.Length > 50)
            throw new ArgumentException("Endereço deve conter no mínimo 1 no máximo 50 caracteres.");
        Value = value;
    }

    public override string ToString() => Value;
}