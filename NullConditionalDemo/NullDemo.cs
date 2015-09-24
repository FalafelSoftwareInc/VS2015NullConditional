using System;
using System.Collections.Generic;

namespace NullConditionalDemo
{
    public class NullDemo
    {
        public event EventHandler DataChanged;

        public void HandleEventWithError()
        {
            var onDataChanged = DataChanged;
            onDataChanged(this, new EventArgs());
        }

        public void RaiseEventWithNullCheck()
        {
            var onDataChanged = DataChanged;
            if (onDataChanged != null)
            {
                onDataChanged(this, new EventArgs());
            }
        }

        public void RaiseEvent()
        {
            DataChanged?.Invoke(this, new EventArgs());
        }

        public string GetNameFromItem(NullDemoData item)
        {
            return item?.Name;
        }

        public int GetIdFromItem(NullDemoData item)
        {
            return item?.Id ?? 0;
        }

        public string GetFirstNameFromList(IList<NullDemoData> list = null)
        {
            return list?[0]?.Name ?? "No Name";
        }
    }
}
