namespace TesteRhex.Data;

public class ToolDiameter
{
    private double Value { get; }

    public ToolDiameter(double value)
    {
        if (double.IsNaN(value) || value <= 0 || value >= 100)
            throw new ArgumentException("Diametro deve ser maior que 0 e menor que 100.");
        Value = value;
    }
}