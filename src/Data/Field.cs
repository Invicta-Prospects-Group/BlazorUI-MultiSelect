namespace Data;

public record Field
{
    public string Id { get; init; } = string.Empty;

    public string Name { get; init; } = string.Empty;

    public object? Value { get; init; }
}
