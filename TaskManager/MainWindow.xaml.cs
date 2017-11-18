using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace TaskManager
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            Priorities.ItemsSource = Enum.GetValues(typeof(ProcessPriorityClass)).Cast<ProcessPriorityClass>();
            Priorities.SelectedIndex = 0;
        }

        private void TasksList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var listBox = (ListBox)sender;

            if (listBox.SelectedItems.Count > 0)
            {
                var viewModel = (ViewModel)DataContext;
                viewModel.SelectedProcess = (Process)listBox.SelectedItems[0];
            }
        }

        private void RefreshButton_OnClick(object sender, RoutedEventArgs e)
        {
            var viewModel = (ViewModel)DataContext;
            viewModel.ResetProcessesList();
        }

        private void ChangePriority_OnClick(object sender, RoutedEventArgs e)
        {
            var priority = (ProcessPriorityClass)Priorities.SelectionBoxItem;
            var viewModel = (ViewModel)DataContext;
            viewModel.ChangePriority(priority);
        }
    }
}
