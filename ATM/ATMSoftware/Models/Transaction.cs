using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSoftware.Models
{
    internal class Transaction
    {

        public int _id { get; }
        public string _name { get; }
        public string _description { get; }
        public DateTime _created { get; }

        public Transaction()
        {

        }

        public Transaction(int id, string name, string desc, DateTime created)
        {
            _id = id;
            _name = name;
            _description = desc;
            _created = created;
        }
    }
}
