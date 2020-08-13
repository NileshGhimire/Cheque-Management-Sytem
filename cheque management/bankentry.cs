using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cheque_management
{
    public partial class bankentry : Form
    {
        private bool IsEditMode =false;
        public bankentry()
        {
            InitializeComponent();
        }
        private void Loadbankentry()
        {
            //query to select data fron Bankentry
            string sql = "select * from bankentry ";
            var dataList = DBconnection.gettablebyquery(sql);
            dataGridbankentry.DataSource = dataList;
        }
        
        private void EnableDisableControl(string mode)//to enabel and disable controls of form 
        {
            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnedit.Enabled = true;
                    btnsave.Enabled = false;
                    txtbnkid.Clear();
                    txtbnkname.Clear();
                    txtbnkaddrss.Clear();
                    dataGridbankentry.Enabled = true;
                    txtbnkname.ReadOnly = true;
                    break;
                case "New"://setting when new is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridbankentry.Enabled = false;
                   txtbnkname.ReadOnly = false;
                   txtbnkid.Clear();
                    txtbnkaddrss.Clear();
                    txtbnkname.Clear();
                    break;
                case "Edit":////setting when edit is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridbankentry.Enabled = false;
                    txtbnkname.ReadOnly = false;
                    break;

            }
        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(IsEditMode==false)
            {
                var insertBankentry = "insert into bankentry(BankId,BankName,BankAddress) values(" +txtbnkid.Text+ ",'" +txtbnkname.Text+ "','" +txtbnkaddrss.Text+ "')";
                DBconnection.ExecuteNonQuery(insertBankentry);
                MessageBox.Show("Data save sucessfully",
                "save bankentry", MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            else
            {
                var updateBankentry = "update bankentry set BankName='" + txtbnkname.Text + "', BankAddress='" + txtbnkaddrss.Text + "' where BankId=" + txtbnkid.Text + "";
                DBconnection.ExecuteNonQuery(updateBankentry);
                
                MessageBox.Show("Data Updated sucessfully",
               "update bankentry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            Loadbankentry();
            EnableDisableControl("Reset");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Show();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbnkid.Text =dataGridbankentry.CurrentRow.Cells["BankId"].Value.ToString();
            txtbnkname.Text = dataGridbankentry.CurrentRow.Cells["BankName"].Value.ToString();
            txtbnkaddrss.Text = dataGridbankentry.CurrentRow.Cells["BankAddress"].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (
            
                MessageBox.Show("Do you really want to delete data",
                    "delete bankentry",MessageBoxButtons.YesNo,MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                var deletebankentry= "delete from bankentry where BankId=" +txtbnkid.Text;
                DBconnection.ExecuteNonQuery(deletebankentry);
                Loadbankentry();
                EnableDisableControl("Reset");
            } 
            }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
           
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void bankentry_Load(object sender, EventArgs e)
        {
            Loadbankentry();
            EnableDisableControl("Reset");
        }
        }
    }

