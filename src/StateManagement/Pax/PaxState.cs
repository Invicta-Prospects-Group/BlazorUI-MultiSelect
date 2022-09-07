using System.Collections.Immutable;
using StateManagementInterface;

namespace StateManagement.Pax;

public record PaxState : IPaxState
{
    public ImmutableList<Data.Pax> PaxList { get; init; } = ImmutableList<Data.Pax>.Empty;
}

