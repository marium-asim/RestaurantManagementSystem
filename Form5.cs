using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Fantasy
{
    public partial class Form5 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form5()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Elma\Documents\BURGER.accdb;
      Persist Security Info=False;";
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            this.customerTableAdapter.Fill(this.bURGERDataSet.Customer);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Customer(CustomerName,PhoneNo,CustomerEmail) VALUES ('" + txtFullName.Text + "','" + txtPhnno.Text + "','" + txtEmail + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                con.Close();
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtFullName.Focus();
                this.bURGERDataSet.Customer.AddCustomerRow(this.bURGERDataSet.Customer.NewCustomerRow());
                customerBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR " + ex);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            txtFullName.Focus();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel.Enabled = false;
            customerBindingSource.ResetBindings(false);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.customerTableAdapter.Fill(this.bURGERDataSet.Customer);
                    customerBindingSource.DataSource = this.bURGERDataSet.Customer;
                }
                else
                {
                    var query = from o in this.bURGERDataSet.Customer
                                where o.CustomerName.Contains(txtSearch.Text) || o.CustomerEmail == txtSearch.Text
                                select o;
                    customerBindingSource.DataSource = query.ToList();
                }
        }

       
    }
}