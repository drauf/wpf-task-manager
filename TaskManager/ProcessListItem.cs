using System.Diagnostics;

namespace TaskManager
{
    public class ProcessListItem
    {
        public int Id => Process.Id;
        public string ProcessName => Process.ProcessName;
        public bool KeepAlive { get; set; }
        public Process Process { get; }

        public ProcessListItem(Process process)
        {
            Process = process;
        }
    }
}
