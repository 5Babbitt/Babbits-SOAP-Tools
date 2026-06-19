using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace SOAP.Editor
{
    public class ObjectField<T> : BaseField<T> where T : UnityEngine.Object
    {
        private readonly ObjectField objectField;

        public ObjectField() : this(null) { }

        public ObjectField(string label) : base(label, new ObjectField())
        {
            objectField = this.Q<ObjectField>();
            objectField.objectType = typeof(T);
            objectField.RegisterValueChangedCallback(evt => value = evt.newValue as T);
        }

        public override T value
        {
            get => base.value;
            set { base.value = value; objectField.SetValueWithoutNotify(value); }
        }
    }
}