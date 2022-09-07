using Data;
using System.Collections.Immutable;

namespace StateManagementInterface;

public interface IPaxState
{
    ImmutableList<Pax> PaxList { get; init; }
}
