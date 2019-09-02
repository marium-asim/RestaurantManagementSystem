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
using System.Configuration;
namespace Fantasy
{
    public partial class Form4 : Form
    {
        OleDbConnection con = new OleDbConnection();    
        public Form4()
        {
            InitializeComponent();    
            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Elma\Documents\BURGER.accdb;
      Persist Security Info=False;";
        }
        private void Form4_Load(object sender, EventArgs e)
        {  
            // TODO: This line of code loads data into the 'bURGERDataSet1.Waiter' table. You can move, or remove it, as needed.
            this.waiterTableAdapter.Fill(this.bURGERDataSet.Waiter);
            waiterBindingSource.DataSource = this.bURGERDataSet.Waiter;
        }
        private void OkBtn_Click(object sender, EventArgs e)
        { try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO Waiter(WaiterName,WaiterID,ContactNo,JoiningDate) VALUES ('" + txtFullName.Text + 
                    "','" + txtID.Text + " ','" + txtPhnno + "','" + txtJoingDate.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Saved");
                con.Close();
                waiterBindingSource.EndEdit();
                waiterTableAdapter.Update(this.bURGERDataSet.Waiter);
                panel.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                waiterBindingSource.ResetBindings(false);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            panel.Enabled = false;
            waiterBindingSource.ResetBindings(false);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {       panel.Enabled = true;
            txtFullName.Focus();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    this.waiterTableAdapter.Fill(this.bURGERDataSet.Waiter);
                    waiterBindingSource.DataSource = this.bURGERDataSet.Waiter;
                }
                else
                {
                    var query = from o in this.bURGERDataSet.Waiter
                                where o.WaiterName.Contains(txtSearch.Text) || o.ContactNo == txtSearch.Text || o.WaiterID == txtSearch.Text
                                select o;
                    waiterBindingSource.DataSource = query.ToList();
                }
            }
        private void InsertBtn_Click(object sender, EventArgs e)
        {try
            { 
                panel.Enabled = true;
                txtFullName.Focus();
                this.bURGERDataSet.Waiter.AddWaiterRow(this.bURGERDataSet.Waiter.NewWaiterRow());
                waiterBindingSource.MoveLast();       
            }
            catch (Exception ex)
            {
                MessageBox.Show(" ERROR "+ex);
            }}
        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.Delete)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    waiterBindingSource.RemoveCurrent();
            }}

        
       
        }
    }
