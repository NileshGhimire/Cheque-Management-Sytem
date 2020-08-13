using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cheque_management
{
    public partial class partyentry : Form
    {
        private bool IsEditMode = false;

private void loadpartyentry()
{
    //query to select data fron Bankentry
    string sql = "select * from partyentry  ";
    var dataList = DBconnection.gettablebyquery(sql);
    dataGridpartyentry.DataSource = dataList;
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
                 txtpartyid.Clear();
                 txtprtyname.Clear();
                 txtprtyadrs.Clear();
                 txtmblno.Clear();
                 txtphone.Clear();
                 txtuserid.Clear();
                    dataGridpartyentry.Enabled = true;
                  txtprtyname.ReadOnly = true;
                    break;
                case "New"://setting when new is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridpartyentry.Enabled = false;
                   txtprtyname.ReadOnly = false;
                
                    txtpartyid.Clear();
                 txtprtyname.Clear();
                    txtprtyadrs.Clear();
                    txtmblno.Clear();
                  txtphone.Clear();
                 txtuserid.Clear();
                    break;
                case "Edit":////setting when edit is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnedit.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridpartyentry.Enabled = false;
                    txtprtyname.ReadOnly = false;
                    break;
    }
}
        public partyentry()
        {
            InitializeComponent();
        }

        private void partyentry_Load(object sender, EventArgs e)
        {
            loadpartyentry();
            EnableDisableControl("Reset");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
                  if(IsEditMode==false)
            {
                var insertpartyentry = "insert into partyentry(PartyId,PartyName,PartyAddress,MobileNo,Telephone,UserID) values('"+txtpartyid.Text+"','"+txtprtyname.Text+"','"+txtprtyadrs.Text+"','"+txtmblno.Text+"','"+txtphone.Text+"','"+txtuserid.Text+"')";
                DBconnection.ExecuteNonQuery(insertpartyentry);
                MessageBox.Show("Data save sucessfully",
                "save UserEntry", MessageBoxButtons.OK,MessageBoxIcon.Information);
                      
            }
            else
            {
                var updatepartyentry = "update partyentry set PartyName='"+txtprtyname.Text+"', PartyAddress='"+txtprtyadrs.Text+"', MobileNo='"+txtmblno.Text+"',Telephone ='"+txtphone.Text+"', UserID='"+txtuserid.Text+"' where partyId='"+txtpartyid.Text+"'";
                      DBconnection.ExecuteNonQuery(updatepartyentry);

                      MessageBox.Show("Data Updated sucessfully",
                     "update PartyEntry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  
            }
            loadpartyentry();
            EnableDisableControl("Reset");
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

        private void btndelete_Click(object sender, EventArgs e)
        {
              if (
            
                MessageBox.Show("Do you really want to delete data",
                    "delete PartyEntry",MessageBoxButtons.YesNo,MessageBoxIcon.Information) ==DialogResult.Yes)
            {
                var deletepartyentry= "delete from partyentry where PartyId=" +txtpartyid.Text;
                DBconnection.ExecuteNonQuery(deletepartyentry);
               loadpartyentry();
                EnableDisableControl("Reset");
            } 
        }

        private void dataGridpartyentry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpartyid.Text  = dataGridpartyentry.CurrentRow.Cells["PartyID"].Value.ToString();
             txtprtyname.Text= dataGridpartyentry.CurrentRow.Cells["PartyName"].Value.ToString();
             txtprtyadrs.Text= dataGridpartyentry.CurrentRow.Cells["PartyAddress"].Value.ToString();
             txtmblno.Text = dataGridpartyentry.CurrentRow.Cells["MobileNo"].Value.ToString();
         
             txtphone.Text = dataGridpartyentry.CurrentRow.Cells["Telephone"].Value.ToString();
            txtuserid.Text=dataGridpartyentry.CurrentRow.Cells["UserID"].Value.ToString();
        }
    }
}
