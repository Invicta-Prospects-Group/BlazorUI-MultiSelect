using Data;
using StateManagementInterface;
using System.Collections.Immutable;

namespace StateManagement.Fields;

public record FieldState : IFieldState
{
    public ImmutableList<Field> Fields { get; init; } = ImmutableList<Field>.Empty;
}
