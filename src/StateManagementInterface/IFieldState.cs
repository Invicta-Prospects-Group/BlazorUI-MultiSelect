using System.Collections.Immutable;
using Data;

namespace StateManagementInterface;

public interface IFieldState
{
    ImmutableList<Field> Fields { get; init;}
}
