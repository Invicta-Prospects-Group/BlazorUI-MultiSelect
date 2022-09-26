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

    [ReducerMethod]
    public static IIconState OnSelectIcon(IIconState state, IconSelectIconAction action)
    {
        return (IconState)state with
        {
            SelectedIcon = action.Selection
        };
    }
}

