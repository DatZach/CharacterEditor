using System;

namespace WpfGui.Helpers.Dialog
{
    public interface IModalDialog
    {
        bool? DialogResult { get; set; }
        event EventHandler Closed;
        void Show();
        object DataContext { get; set; }
        void Close();
    }
}
