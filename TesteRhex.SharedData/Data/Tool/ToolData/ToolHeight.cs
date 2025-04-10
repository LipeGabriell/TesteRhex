namespace TesteRhex.Data;

public class ToolHeight
{
    private double Value { get; }

    public ToolHeight(double value)
    {
        if (double.IsNaN(value) || value <= 0 || value >= 100)
            throw new ArgumentException("Altura deve ser maior que 0 e menor que 100.");
        Value = value;
    }
}