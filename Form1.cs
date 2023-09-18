using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public object MyConnection { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();
                //MessageBox.Show("Connection success");

                string qry = "select * from user";

                MySqlCommand mySqlCommand = new MySqlCommand(qry);
                mySqlCommand.Connection = mySqlConnection;

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mysqlCon = "server=127.0.0.1; user=root; database=sampleconnecrtion; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);

            try
            {
                mySqlConnection.Open();

                string qry = "select * from user where username='" + txtusername.Text + "' and password='" + txtpasssword.Text + "';";

                MySqlCommand mySqlCommand = new MySqlCommand(qry);
                mySqlCommand.Connection = mySqlConnection;

                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = mySqlCommand;
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {


                    MessageBox.Show("Welcome Back, Brightonian!");
                    this.Hide();
                    Logout l = new Logout();
                    l.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Login, Incorrect Username/Password.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

    }
}
