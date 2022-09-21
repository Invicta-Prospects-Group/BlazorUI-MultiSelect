using System;
using Data;
using System.Collections.Immutable;

namespace StateManagementInterface;

public interface IIconState
{
    ImmutableList<Icon> Icons { get; init; }
}