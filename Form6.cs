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
    public partial class Form6 : Form
    {
        OleDbConnection con = new OleDbConnection();
        public Form6()
        {
            InitializeComponent();
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Elma\Documents\BURGER.accdb;
      Persist Security Info=False;";
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bURGERDataSet.Chef' table. You can move, or remove it, as needed.
            this.chefTableAdapter.Fill(this.bURGERDataSet.Chef);
            chefBindingSource.DataSource = this.bURGERDataSet.Chef;

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
            chefBindingSource.ResetBindings(false);
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.chefTableAdapter.Fill(this.bURGERDataSet.Chef);
                    chefBindingSource.DataSource = this.bURGERDataSet.Chef;
                }
                else
                {
                    var query = from o in this.bURGERDataSet.Chef
                                where o.Chef_Name.Contains(txtSearch.Text)
                                select o;
                    chefBindingSource.DataSource = query.ToList();
                }
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                txtFullName.Focus();
                this.bURGERDataSet.Chef.AddChefRow(this.bURGERDataSet.Chef.NewChefRow());
                chefBindingSource.MoveLast();

            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR " + ex);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Chef(ChefName,ChefID,ContactNo) VALUES ('" + txtFullName.Text + "','" + txtID.Text + " ','" + txtPhnno + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                con.Close();
                chefBindingSource.EndEdit();
                chefTableAdapter.Update(this.bURGERDataSet.Chef);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chefBindingSource.ResetBindings(false);
            }
        }

        private void dltBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM Chef where ChefID= '" + txtID.Text + " ' "; 
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted");
                con.Close();
                chefBindingSource.EndEdit();
                chefTableAdapter.Update(this.bURGERDataSet.Chef);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chefBindingSource.ResetBindings(false);
            }
        }
    }
}