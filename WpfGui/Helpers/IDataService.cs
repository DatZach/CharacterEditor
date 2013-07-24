using System;
using WpfGui.Model;

namespace WpfGui.Helpers
{
    public interface IDataService
    {
        void GetData(Action<DataItem, Exception> callback);
    }
}
