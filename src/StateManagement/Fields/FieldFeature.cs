using Fluxor;
using StateManagementInterface;
using System.Collections.Immutable;

namespace StateManagement.Fields;

public class FieldFeature : Feature<IFieldState>
{
    public override string GetName() => "Fields";

    protected override IFieldState GetInitialState()
    {
        return new FieldState
        {
            Fields = ImmutableList.Create(
                new Data.Field
                {
                    Id = "01",
                    Name = "Pax Selector",
                    Value = ImmutableList<string>.Empty.Add("pax_000001").Add("pax_000003").Add("pax_000004").Add("pax_000007").Add("pax_000008").ToList()
                },

                new Data.Field
                {
                    Id = "02",
                    Name = "Icon Selector",
                    Value = ImmutableList<string>.Empty
                }
            )
        };
    }
}

