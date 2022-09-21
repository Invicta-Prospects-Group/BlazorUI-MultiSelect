using Data;
using System.Collections.Immutable;
using Fluxor;
using StateManagement.Fields.Actions;
using StateManagementInterface;

namespace StateManagement.Fields;

public static class FieldReducers
{

    [ReducerMethod]
    public static IFieldState OnChangeValue(IFieldState state, FieldChangeValueAction action)
    {
        var target = state.Fields.FirstOrDefault(f => f.Id == action.Id);

        if (target == null) return (FieldState)state;

        var amended = target with
        {
            Value = action.Value
        };

        return (FieldState)state with
        {
            Fields = state.Fields.Remove(target).Add(amended)
        };
    }

    [ReducerMethod]
    public static IFieldState OnClear(IFieldState state, FieldClearAction action)
    {
        var target = state.Fields.FirstOrDefault(f => f.Id == action.fieldId);

        if (target == null) return (FieldState)state;

        var amended = target with
        {
            Value = null
        };

        return (FieldState)state with
        {
            Fields = state.Fields.Remove(target).Add(amended)
        };
    }
}
