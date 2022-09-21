using Fluxor;
using StateManagementInterface;
using System.Collections.Immutable;

namespace StateManagement.Icons;

public class IconFeature : Feature<IIconState>
{
    public override string GetName() => "Icons";

    protected override IIconState GetInitialState()
    {
        return new IconState
        {
            Icons = ImmutableList.Create(
                new Data.Icon
                {
                    Order = 1,
                    Description = "caret tr",
                    ClassName = "caret tr"
                }
            )
        };
    }
}

