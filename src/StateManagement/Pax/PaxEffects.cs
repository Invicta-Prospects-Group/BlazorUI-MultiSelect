using Fluxor;
using StateManagement.Pax.Actions;
using System.Net.Http.Json;
using System.Collections.Immutable;

namespace StateManagement.Pax;


public class PaxEffects
{
    private readonly HttpClient _httpClient;

    public PaxEffects(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [EffectMethod(typeof(PaxLoadPaxAction))]
    public async Task LoadPaxLibrary(IDispatcher dispatcher)
    {
        var data = await _httpClient.GetFromJsonAsync<List<Data.Pax>>("sample-data/pax-data.json");

        dispatcher.Dispatch(new PaxAddPaxAction(data!.ToImmutableList()));
    }
}
