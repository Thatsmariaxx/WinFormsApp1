using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Logout : Form
    {



        public Logout()
        {
            InitializeComponent();
        }

        DateTime datetime = new DateTime();

        private void Logout_Load(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            datetime = DateTime.Now;
            this.label1.Text = datetime.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }
    }
}