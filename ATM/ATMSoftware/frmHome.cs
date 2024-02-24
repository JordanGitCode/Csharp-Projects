using ATMSoftware.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace ATMSoftware
{

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        static List<Transaction> transactionList = new List<Transaction>();

        private void frmHome_Load(object sender, EventArgs e)
        {

            /*transactionList.Add(new Transaction(0, "t0", "1st transaction", DateTime.Now));
            transactionList.Add(new Transaction(1, "t1", "2nd transaction", DateTime.Now));*/

            transactionList = Deserialize();

            dataGridView1.DataSource = transactionList;
            formatDGV();
        }

        private void formatDGV()
        {
            dataGridView1.Columns[0].HeaderText = "Transaction ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[3].HeaderText = "Date";
        }

        private void Serialize(List<Transaction> tList)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Transaction>));
            StreamWriter writer = File.CreateText("tFile.txt");
            serializer.Serialize(writer, tList);
        }

        private List<Transaction> Deserialize()
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<Transaction>));
            StreamReader reader = File.OpenText("tFile.txt");
            

            return (List<Transaction>)deserializer.Deserialize(reader);
        }

        private void frmHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Serialize(transactionList);
        }
    }
}
