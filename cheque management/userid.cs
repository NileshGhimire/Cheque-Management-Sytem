using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cheque_management
{
    public partial class userid : Form
    {
        private bool IsEditMode=false;
        public userid()
        {
            InitializeComponent();
        }
        private void loadUserEntry()
    {
         //query to select data fron Bankentry
            string sql = "select * from Userid ";
            var dataList = DBconnection.gettablebyquery(sql);
            dataGridUserEntry.DataSource = dataList;
        }
         private void EnableDisableControl(string mode)//to enabel and disable controls of form 
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndlt.Enabled = false;
                    btnedit.Enabled = true;
                    btnsave.Enabled = false;
                    txtuserid.Clear();
                    txtstaffname.Clear();
                    txtemail.Clear();
                    txtusername.Clear();
                    txtpswrd.Clear();
                    txtphone.Clear();
                    dataGridUserEntry.Enabled = true;
                  txtstaffname.ReadOnly = true;
                    break;
                case "New"://setting when new is click 
                    btnnew.Enabled = false;
                    btndlt.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridUserEntry.Enabled = false;
                   txtstaffname.ReadOnly = false;
                   txtuserid.Clear();
                    txtstaffname.Clear();
                    txtemail.Clear();
                    txtusername.Clear();
                    txtpswrd.Clear();
                    txtphone.Clear();
                    break;
                case "Edit":////setting when edit is click 
                    btnnew.Enabled = false;
                    btndlt.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridUserEntry.Enabled = false;
                    txtstaffname.ReadOnly = false;
                    break;

            }
         }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void userid_Load(object sender, EventArgs e)
        {
            loadUserEntry();
            EnableDisableControl("Reset");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
                if(IsEditMode==false)
            {
                var insertUserEntry = "insert into Userid(UserID,StaffName,Email,UserName,Password,Telephone) "+
                    "values('"+txtuserid.Text+"','"+txtstaffname.Text+"','"+txtemail.Text+"','"+txtusername.Text+"','"+txtpswrd.Text+"','"+txtphone.Text+"')";
                DBconnection.ExecuteNonQuery(insertUserEntry);
                MessageBox.Show("Data save sucessfully",
                "save UserEntry", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                var updateUserEntry = "update Userid set StaffName='"+txtstaffname.Text+"', Email='"+txtemail.Text+"', UserName='"+txtusername.Text+"',"+
                    "Password= '"+txtpswrd.Text+"', Telephone='"+txtphone.Text+"' where UserID='"+txtuserid.Text+"'";
                DBconnection.ExecuteNonQuery(updateUserEntry);
                
                MessageBox.Show("Data Updated sucessfully",
               "update UserEntry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            loadUserEntry();
            EnableDisableControl("Reset");
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void btndlt_Click(object sender, EventArgs e)
        {
             if (
            
                MessageBox.Show("Do you really want to delete data",
                    "delete UserEntry",MessageBoxButtons.YesNo,MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                var deletebankentry = "delete from Userid where UserID=" + txtuserid.Text;
                DBconnection.ExecuteNonQuery(deletebankentry);
                loadUserEntry();
                EnableDisableControl("Reset");
             }
            }

        private void dataGriduserid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           txtuserid.Text  = dataGridUserEntry.CurrentRow.Cells["UserID1"].Value.ToString();
             txtstaffname.Text= dataGridUserEntry.CurrentRow.Cells["StaffName"].Value.ToString();
             txtemail.Text= dataGridUserEntry.CurrentRow.Cells["Email"].Value.ToString();
             txtusername.Text = dataGridUserEntry.CurrentRow.Cells["UserName"].Value.ToString();
             txtpswrd.Text = dataGridUserEntry.CurrentRow.Cells["Password"].Value.ToString();
             txtphone.Text = dataGridUserEntry.CurrentRow.Cells["Telephone"].Value.ToString();
        }
        }
        }
        
    

