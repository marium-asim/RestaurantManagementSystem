using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
namespace Fantasy
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5000);
            t.Abort();
            InitializeComponent();
        }
        public void SplashStart()
        {
            Application.Run(new Form2());
        }  
    private void Form1_Load(object sender, EventArgs e)
        {

            
            
   
           
        }
       private void LogBtn_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();



      

        }
        private void extBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    

      
    }
    }


