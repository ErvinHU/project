using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace InventoryManagmentSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            string mysqlCon = "server=127.0.0.1; user=root; database=v-forg; password=";
            MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon);
            try
            {
                mySqlConnection.Open();
                string query = "SELECT * FROM megrendelések";
                MySqlCommand cmd = new MySqlCommand(query, mySqlConnection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.KeyPreview = true;
            txtName.KeyDown += new KeyEventHandler(txtName_KeyDown);
            txtPass.KeyDown += new KeyEventHandler(txtPass_KeyDown);
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPass.UseSystemPasswordChar = !checkBoxPass.Checked;
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                PerformLogin();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PerformLogin();
            }
        }

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtPass.Clear();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kívánja bezárni a programot?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformLogin();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void PerformLogin()
        {
            string username = txtName.Text;
            string password = txtPass.Text;

            // Define your connection string (make sure it's correct)
            string mysqlCon = "server=127.0.0.1; user=root; database=v-forg; password=";

            using (MySqlConnection mySqlConnection = new MySqlConnection(mysqlCon))
            {
                try
                {
                    mySqlConnection.Open();
                    string query = "SELECT COUNT(1) FROM felhasznalok WHERE Username=@username AND Password=@password";

                    using (MySqlCommand cmd = new MySqlCommand(query, mySqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            this.Hide();
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void minimizeWindow_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
