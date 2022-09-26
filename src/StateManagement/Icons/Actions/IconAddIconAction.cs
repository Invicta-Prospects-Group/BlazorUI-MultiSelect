using System;
using System.Collections.Immutable;
using System.Diagnostics;

namespace StateManagement.Icons.Actions;

public class IconAddIconAction
{
    public ImmutableList<Data.Icon> IconList { get; }

    public IconAddIconAction(ImmutableList<Data.Icon> iconList)
    {
        IconList = iconList;
    }
}

