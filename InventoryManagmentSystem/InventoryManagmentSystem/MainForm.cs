using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InventoryManagmentSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {

            InitializeComponent();
            string mysqlCon = "server=127.0.0.1; user=root; database=v-forg; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();

                //Connection check
                //MessageBox.Show("Connection success");


                string query = "SELECT * FROM megrendelések";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kívánja bezárni a programot?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        public Point mouseLocation;

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            //check why - and + is different
            mouseLocation = new Point(e.X, e.Y);
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePose = Control.MousePosition;
                mousePose.Offset(mouseLocation.X,mouseLocation.Y);
                Location = mousePose;
            }
        }
    }
}
