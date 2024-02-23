using System;
using System.Windows.Forms;

namespace ATMSoftware
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            int len = rtbPinEntry.Text.Length;
            string btnContent = (sender as Button).Text;

            if (btnContent == "<--")
            {
                try
                {
                    rtbPinEntry.Text = rtbPinEntry.Text.Remove(len - 1, 1);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else if (btnContent == "X")
                rtbPinEntry.Text = "";
            else
                rtbPinEntry.Text += btnContent;

        }

        private void Continue(object sender, EventArgs e)
        {
            frmHome homeScreen = new frmHome();
            homeScreen.Show();
        }
    }
}
