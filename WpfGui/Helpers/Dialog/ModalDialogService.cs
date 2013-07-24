using System;

namespace WpfGui.Helpers.Dialog
{
    public class ModalDialogService : IModalDialogService
    {
        public void ShowDialog<TDialogViewModel>(IModalDialog view, TDialogViewModel viewModel, Action<TDialogViewModel> onDialogClose)
        {
            view.DataContext = viewModel;
            if (onDialogClose != null)
            {
                view.Closed += (sender, e) => onDialogClose(viewModel);
            }
            view.Show();
        }

        public void ShowDialog<TDialogViewModel>(IModalDialog view, TDialogViewModel viewModel)
        {
            ShowDialog(view, viewModel, null);
        }
    }
}
