using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ATMSoftware.Models
{
    public class Transaction
    {
        [XmlAttribute]
        public int _id { get; set; }
        [XmlAttribute]
        public string _name { get; set; }
        [XmlAttribute]
        public string _description { get; set; }
        [XmlAttribute]
        public DateTime _created { get; set; }

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
