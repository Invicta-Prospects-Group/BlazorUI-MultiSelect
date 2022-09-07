using Fluxor;
using StateManagement.Pax.Actions;
using StateManagementInterface;

namespace StateManagement.Pax;

public static class PaxReducers
{
    [ReducerMethod]
    public static IPaxState OnAddPax(IPaxState state, PaxAddPaxAction action)
    {
        return (PaxState)state with
        {
            PaxList = action.PaxList
        };
    }
}