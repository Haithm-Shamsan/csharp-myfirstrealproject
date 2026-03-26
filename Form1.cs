using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankProject_BisnessLayer;

namespace MyFirstRealProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ShowClientList()
        {
            //dataGridView1.DataSource = clsBankBisness.ShowClientList();
       
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
             Home home = new Home();
        private void btnEnter_Click(object sender, EventArgs e)
        {

            clsPerson Client1 = clsPerson.FindP(Convert.ToInt32( txtUserName.Text));

            if(Client1!=null)
            { home.ShowDialog();
               

            }else
            { MessageBox.Show("Wrong UserName/Password");
                txtUserName.Clear();
                txtPassword.Clear();
                return;
        
            }
                     
              
                 
            





        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
