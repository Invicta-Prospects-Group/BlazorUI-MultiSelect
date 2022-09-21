using System;
namespace StateManagement.Fields.Actions
{
    public class FieldClearAction
    {
        public string fieldId { get; set; }
        public FieldClearAction(string id)
        {
            fieldId = id;
        }
    }
}

