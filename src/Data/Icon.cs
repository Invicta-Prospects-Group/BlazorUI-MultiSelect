namespace Data;

public record Icon
{
    public int Order { get; init; }

    public string Description { get; init; } = string.Empty;

    public string ClassName { get; init; } = string.Empty;
}