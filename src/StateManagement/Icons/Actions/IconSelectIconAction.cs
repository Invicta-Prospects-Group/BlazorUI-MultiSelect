using System;
using Data;

namespace StateManagement.Icons.Actions;

public class IconSelectIconAction
{
    public Icon Selection { get; }

    public IconSelectIconAction(Icon selection)
    {
        Selection = selection;
    }
}

