using System;

namespace WpfGui.Helpers.Dialog
{
    public interface IModalDialogService
    {
        void ShowDialog<TViewModel>(IModalDialog view, TViewModel viewModel, Action<TViewModel> onDialogClose);

        void ShowDialog<TDialogViewModel>(IModalDialog view, TDialogViewModel viewModel);
    }
}
