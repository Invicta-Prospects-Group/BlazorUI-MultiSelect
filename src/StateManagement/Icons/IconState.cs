using System;
using Data;
using StateManagementInterface;
using System.Collections.Immutable;

namespace StateManagement.Icons;

public record IconState : IIconState
{
    public ImmutableList<Icon> Icons { get; init; } = ImmutableList<Icon>.Empty;
}