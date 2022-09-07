using System.Text.Json.Serialization;

namespace Data;

public record Pax
{
    public string PaxId { get; init; } = string.Empty;

    public string Title { get; init; } = string.Empty;

    public string FirstName { get; init; } = string.Empty;

    public string LastName { get; init; } = string.Empty;

    public string FullName => $"{Title} {FirstName} {LastName}";
}