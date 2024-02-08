using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Things_To_Do
{
	public class Task
	{

		private string tName { get; set; }
		private string tDescription { get; set; }
		private string tLocation { get; set; }
        private bool tImportant { get; set; }
		private bool tComplete { get; set; }

		public Task() { }

		public Task(string name, string description, string location, bool important, bool complete)
		{
			tName = name;
			tDescription = description;
			tLocation = location;
			tImportant = important;
			tComplete = complete;
		}

    }
}
