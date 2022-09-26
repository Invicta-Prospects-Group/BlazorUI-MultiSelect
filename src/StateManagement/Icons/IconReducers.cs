using Fluxor;
using StateManagement.Icons.Actions;
using StateManagementInterface;

namespace StateManagement.Icons;

public class IconReducers
{
    [ReducerMethod]
    public static IIconState OnAddIcon(IIconState state, IconAddIconAction action)
    {
        return (IconState)state with
        {
            Icons = action.IconList
        };
    }
}

