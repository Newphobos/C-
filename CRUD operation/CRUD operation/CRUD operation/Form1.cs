using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_operation
{
    public partial class Form1 : Form
    {


        Customer model = new Customer();
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Clear();
            
        }

        void Clear()
        {
            txtAddress.Text = txtFirstName.Text = txtLastName.Text = txtCity.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.CustomerID = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            model.First_Name = txtFirstName.Text.Trim();
            model.Last_Name = txtLastName.Text.Trim();
            model.Address = txtAddress.Text.Trim();
            model.City = txtCity.Text.Trim();


            using (DBEntities db = new DBEntities())
            {

                db.Customers.Add(model);
                db.SaveChanges();
            
            }
            Clear();
            MessageBox.Show("Submitted Successfully");
        }

        void PopulateDataGridView()
        {

            using (DBEntities db = new DBEntities)
            { 
                
            
            
            }
        
        }
    }
}
