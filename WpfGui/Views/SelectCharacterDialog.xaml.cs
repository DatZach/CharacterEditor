using GalaSoft.MvvmLight.Messaging;
using MahApps.Metro.Controls;
using WpfGui.Helpers.Dialog;
using WpfGui.Helpers.Messages;

namespace WpfGui.Views
{
    /// <summary>
    /// Interaction logic for SelectCharacterDialog.xaml
    /// </summary>
    public partial class SelectCharacterDialog : MetroWindow, IModalDialog
    {
        public SelectCharacterDialog()
        {
            InitializeComponent();
            Messenger.Default.Register<CloseSelectCharacterDialogMessage>(this, delegate { Close(); });
        }

        private void CloseCommandHandler(object sender, System.Windows.Input.ExecutedRoutedEventArgs e)
        {
            Close();
        }
    }
}
