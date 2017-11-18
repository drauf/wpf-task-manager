using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Threading;

namespace TaskManager
{
    public class ViewModel
    {
        public ObservableCollection<Process> Processes { get; } = new ObservableCollection<Process>();

        public ViewModel()
        {
            var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(2) };
            timer.Tick += UpdateProcesses;
            timer.Start();
        }

        private void UpdateProcesses(object sender, EventArgs e)
        {
            var currentIds = Processes.Select(p => p.Id).ToList();

            foreach (var p in Process.GetProcesses())
            {
                if (!currentIds.Remove(p.Id)) // it's a new process id
                {
                    Processes.Add(p);
                }
            }

            foreach (var id in currentIds) // these do not exist any more
            {
                Processes.Remove(Processes.First(p => p.Id == id));
            }
        }
    }
}
