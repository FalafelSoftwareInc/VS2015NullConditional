using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullConditionalDemo
{
    public class NullDemo
    {
        public event EventHandler DataChanged;

        public void HandleEventWithError()
        {
            DataChanged(this, new EventArgs());
        }

        public void HandleEventWithNullCheck()
        {
            if (DataChanged != null)
            {
                DataChanged(this, new EventArgs());
            }
        }

        public void HandleEvent()
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

    public class NullDemoData
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }
}
