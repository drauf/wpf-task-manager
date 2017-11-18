using System.Diagnostics;
using System.Windows.Controls;

namespace TaskManager
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void tasksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = (ViewModel) DataContext;
            var listBox = (ListBox) sender;
            viewModel.SelectedProcess = (Process) listBox.SelectedItems[0];
        }
    }
}
