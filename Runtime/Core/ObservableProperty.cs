using System;

namespace Tobe.Core
{
    [Serializable]
    public class ObservableProperty<TValue>
    {
        private TValue _value;

        public ObservableProperty()
        {
            
        }

        public ObservableProperty(TValue value)
        {
            _value = value;
        }
        
        public TValue Get()
        {
            return _value;
        }

        public void Set(TValue value)
        {
            if (value.Equals(_value))
            {
                return;
            }

            _value = value;
            
            OnChanged(_value);
        }

        public void SetSilently(TValue value)
        {
            if (value.Equals(_value))
            {
                return;
            }
            _value = value;

        }
        
        public event EventHandler<TValue> Changed;

        protected virtual void OnChanged(TValue e)
        {
            Changed?.Invoke(this, e);
        }
    }
}