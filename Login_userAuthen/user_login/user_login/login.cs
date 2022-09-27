using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace user_login
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ITLUQC4Q\SQLEXPRESS;Initial Catalog=AirHeaterTemp;Integrated Security=True");
            string query = "Select * from user_authen where username = '" + txt_Username.Text + "' and password = '" + txt_password.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();

            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1 | dtbl.Rows.Count == 2)
            {
                this.Hide();
                main_form objMainform = new main_form();
                objMainform.Show();

            }
            else
            {
                MessageBox.Show("Please check the username and password");
            
            }

        }
    }
}
