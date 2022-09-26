using Fluxor;
using StateManagement.Icons.Actions;
using System.Net.Http.Json;
using System.Collections.Immutable;
using Data;

namespace StateManagement.Icons;

public class IconEffects
{
    private readonly HttpClient _httpClient;

    public IconEffects(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    [EffectMethod(typeof(IconLoadIconsAction))]
    public async Task LoadIconLibrary(IDispatcher dispatcher)
    {
        var data = await _httpClient.GetFromJsonAsync<List<Icon>>("sample-data/telerik-icons.json");

        dispatcher.Dispatch(new IconAddIconAction(data!.ToImmutableList()));
    }
}