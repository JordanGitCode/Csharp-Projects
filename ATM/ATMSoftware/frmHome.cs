using ATMSoftware.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ATMSoftware
{

    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();   
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            List<Transaction> transactionList = new List<Transaction>();
            transactionList.Add(new Transaction(0, "t0", "1st transaction", DateTime.Now));
            transactionList.Add(new Transaction(1, "t1", "2nd transaction", DateTime.Now));
            dataGridView1.DataSource = transactionList;
            dataGridView1.Columns[0].HeaderText = "Transaction ID";
            dataGridView1.Columns[1].HeaderText = "Name";
            dataGridView1.Columns[2].HeaderText = "Description";
            dataGridView1.Columns[3].HeaderText = "Date";
        }
    }
}
