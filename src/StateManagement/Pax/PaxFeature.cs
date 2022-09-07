using Fluxor;
using StateManagementInterface;

namespace StateManagement.Pax;

public class PaxFeature : Feature<IPaxState>
{
    public override string GetName() => "Pax Library";

    protected override IPaxState GetInitialState()
    {
        return new PaxState();
    }
}