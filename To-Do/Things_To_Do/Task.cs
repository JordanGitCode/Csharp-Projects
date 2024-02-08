using System.ComponentModel;

namespace Things_To_Do
{
    public class Task : INotifyPropertyChanged
    {
        private string _taskName;
        private string _description;
        private int _priority;
        private bool _done;

        public Task() { }

        public Task(string taskName, string description, int priority, bool done)
        {
            _description = description;
            _taskName = taskName;
            _priority = priority;
            _done = done;
        }

        public string TaskName
        {
            get { return _taskName; }
            set
            {
                _taskName = value;
                OnPropertyChanged("TaskName");
            }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public int Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                OnPropertyChanged("Priority");
            }
        }

        public bool Done
        {
            get { return _done; }
            set
            {
                _done = value;
                OnPropertyChanged("TaskType");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString() => _taskName;

        protected void OnPropertyChanged(string info)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(info));
        }
    }
}
