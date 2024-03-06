using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftware.Models
{
    class Bank
    {

        public string name {  get; set; }
        public int branchID {  get; set; }
        public string branchName { get; set; }

        public Bank(string name, int branchID, string branchName)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.branchID = branchID;
            this.branchName = branchName ?? throw new ArgumentNullException(nameof(branchName));
        }
    }
}
