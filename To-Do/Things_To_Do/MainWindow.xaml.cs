using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Things_To_Do
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Add_Task_Click(object sender, RoutedEventArgs e)
		{
			Tasks tasksInstance = new Tasks();
			Task task = new Task("", "", 1, true);
			tasksInstance.Add(task);
		}

		private void Edit_Task_Click(object sender, RoutedEventArgs e)
		{

		}

		private void Delete_Task_Click(object sender, RoutedEventArgs e)
		{

		}
	}
}