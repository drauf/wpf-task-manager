using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;

namespace TaskManager
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TasksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var viewModel = (ViewModel) DataContext;
            var listBox = (ListBox) sender;
            viewModel.SelectedProcess = (Process) listBox.SelectedItems[0];
        }

        private void RefreshButton_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (ViewModel)DataContext;
            viewModel.UpdateProcesses(sender, e);
        }
    }
}
