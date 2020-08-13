using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using cheque_management;

namespace cheque_management
{
    public partial class Login : Form
    {
        public bool IscancelPressed;
        public Login()
        {
            InitializeComponent();
        }
      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            IscancelPressed=true;
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                var data = DBconnection.gettablebyquery("Select * from userid where UserName='" + txtusername.Text.Trim() +
                                       "' and Password='" + txtpswrd.Text.Trim() + "'");
                if (data.Rows.Count > 0)
                {
                    CommonInfo.UserId = (int)data.Rows[0]["UserId"];
                    CommonInfo.StaffName = data.Rows[0]["StaffName"].ToString();
                    CommonInfo.Email = data.Rows[0]["Email"].ToString();
                    CommonInfo.UserName = data.Rows[0]["UserName"].ToString();
                    CommonInfo.Password = txtpswrd.Text;
                    CommonInfo.Telephone = data.Rows[0]["Telephone"].ToString();
                    mainform mf = new mainform();
                    mf.ShowDialog();
                }

                else
                {
                    MessageBox.Show("username password doesnot match .");
                    txtpswrd.Focus();
                    txtpswrd.SelectAll();
                    //password error message
                    
                }

            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        }
    }

