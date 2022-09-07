using Fluxor;
using Microsoft.AspNetCore.Components;
using StateManagementInterface;
using Data;
using StateManagement.Fields.Actions;

namespace Client;

public class DynamicFieldBase : ComponentBase, IDisposable
{

#pragma warning disable CS8618

    [Inject]
    protected IState<IFieldState> FieldState { get; set; }

    [Inject]
    protected IState<IPaxState> PaxState { get; set; }

    [Inject]
    private IDispatcher Dispatcher { get; set; }

#pragma warning restore CS8618

    [Parameter]
    public string FieldId { get; set; } = string.Empty;

    internal Field? Field => FieldState.Value.Fields.FirstOrDefault(f => f.Id == FieldId);

    internal string Name => Field?.Name ?? string.Empty;

    public List<Pax> PaxData => PaxState.Value.PaxList.ToList();

    protected override void OnInitialized()
    {
        FieldState!.StateChanged += OnStateChanged;
        PaxState!.StateChanged += OnStateChanged;
        base.OnInitialized();
    }

    public void Dispose()
    {
        FieldState!.StateChanged -= OnStateChanged;
        PaxState!.StateChanged -= OnStateChanged;
        GC.SuppressFinalize(this);
    }

    private void OnStateChanged(object? sender, EventArgs e)
    {
        StateHasChanged();
    }

    public void ChangeFieldValue(object newValue)
    {
        Dispatcher.Dispatch(new FieldChangeValueAction(FieldId, newValue));
    }
}
