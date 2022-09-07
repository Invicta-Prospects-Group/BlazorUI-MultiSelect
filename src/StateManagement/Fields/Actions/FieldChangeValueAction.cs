namespace StateManagement.Fields.Actions;

public class FieldChangeValueAction
{
   
    public string Id { get; }
    
    public object Value { get; }

    public FieldChangeValueAction(string id, object value)
    {
        Id = id;
        Value = value;
    }
}
