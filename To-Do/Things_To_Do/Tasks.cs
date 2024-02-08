using System.Collections.ObjectModel;

namespace Things_To_Do
{
    public class Tasks : ObservableCollection<Task>
    {
        public Tasks()
        {
            Add(new Task("Groceries", "Pick up Groceries and Detergent", 1, true));
            Add(new Task("Train", "Head to the track", 3, false));
            Add(new Task("Read", "50 Pages", 2, false));
        }
    }
}
