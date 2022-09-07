using System.Collections.Immutable;

namespace StateManagement.Pax.Actions;

public class PaxAddPaxAction
{
    public ImmutableList<Data.Pax> PaxList { get; }
    
    public PaxAddPaxAction(ImmutableList<Data.Pax> paxList)
    {
        PaxList = paxList;
    }
}
