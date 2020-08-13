using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cheque_management
{
    public partial class chequeentry : Form
    {
        public chequeentry()
        {
            InitializeComponent();
        }
        private bool IsEditMode = false;

        private void loadchequeentry()
        {
            //query to select data fron Bankentry
            string sql = "select * from chequeentry  ";
            var dataList = DBconnection.gettablebyquery(sql);
            dataGridchequeentry.DataSource = dataList;
        }

        private void EnableDisableControl(string mode)//to enabel and disable controls of form 
        {

            switch (mode)
            {
                case "Reset"://to reset form
                    btnnew.Enabled = true;
                    btndelete.Enabled = false;
                    btnupdate.Enabled = true;
                    btnsave.Enabled = false;
                    txtprtyid.Clear();
                    txtbnkid.Clear();
                    txtchqno.Clear();
                    txtchqbearer.Clear();

                    txtuserid.Clear();

                    dataGridchequeentry.Enabled = true;
                    txtbnkid.ReadOnly = true;
                    break;
                case "New"://setting when new is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = false;
                    btnupdate.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridchequeentry.Enabled = false;
                    txtbnkid.ReadOnly = false;

                    txtprtyid.Clear();
                    txtbnkid.Clear();
                    txtchqno.Clear();
                    txtchqbearer.Clear();

                    txtuserid.Clear();
                    break;
                case "Edit":////setting when edit is click 
                    btnnew.Enabled = false;
                    btndelete.Enabled = true;
                    btnupdate.Enabled = false;
                    btnsave.Enabled = true;
                    dataGridchequeentry.Enabled = false;
                    txtbnkid.ReadOnly = false;
                    break;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Show();
            mainform mf = new mainform();
            mf.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void chequeentry_Load(object sender, EventArgs e)
        {
            loadchequeentry();
            EnableDisableControl("Reset");
        }

        private void dataGridchequeentry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtchequeid.Text = dataGridchequeentry.CurrentRow.Cells["ChequeId"].Value.ToString();
            txtbnkid.Text = dataGridchequeentry.CurrentRow.Cells["BankId"].Value.ToString();
            txtprtyid.Text = dataGridchequeentry.CurrentRow.Cells["PartyId"].Value.ToString();
            txtchqno.Text = dataGridchequeentry.CurrentRow.Cells["ChequeNo"].Value.ToString();
            txtchqbearer.Text = dataGridchequeentry.CurrentRow.Cells["ChequeBearer"].Value.ToString();
            dateTimeentrydate.Value = Convert.ToDateTime(dataGridchequeentry.CurrentRow.Cells["EntryDate"].Value.ToString());

            dateTimedateofcash.Value = Convert.ToDateTime(dataGridchequeentry.CurrentRow.Cells["DateOfCash"].Value.ToString());
            txtuserid.Text = dataGridchequeentry.CurrentRow.Cells["UserID"].Value.ToString();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (IsEditMode == false)
            {
                var insertchequeentry = "insert into chequeentry(ChequeId,BankID,PartyId,ChequeNo,ChequeBearer,EntryDate,DateOfCash,UserId) values('" + txtchequeid.Text + "','" + txtbnkid.Text + "','" + txtprtyid.Text + "','" + txtchqno.Text + "','" + txtchqbearer.Text + "','" + dateTimeentrydate.Value.Date.ToString("MM-dd-yyyy") + "','" + dateTimedateofcash.Value.Date.ToString("MM-dd-yyyy") + "','" + txtuserid.Text + "')";
                DBconnection.ExecuteNonQuery(insertchequeentry);
                MessageBox.Show("Data save sucessfully",
                "save UserEntry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                var updatchequeentry = "Update chequeentry set BankID='" + txtbnkid.Text + "',PartyId='" + txtprtyid.Text + "',ChequeNo='" + txtchqno.Text + "',ChequeBearer='" + txtchqbearer.Text + "',EntryDate='" + dateTimeentrydate.Value.Date.ToString("MM-dd-yyyy") + "',DateOfCash='" + dateTimedateofcash.Value.Date.ToString("MM-dd-yyyy") + "',UserId='" + txtuserid.Text + "' where chequeId='" + txtchequeid.Text + "'";
                DBconnection.ExecuteNonQuery(updatchequeentry);

                MessageBox.Show("Data Updated sucessfully",
               "update chequeEntry", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            loadchequeentry();
            EnableDisableControl("Reset");
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (

               MessageBox.Show("Do you really want to delete data",
                   "delete chequeentry", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                var deletechequeentry = "delete from chequeentry where chequeId=" + txtchequeid.Text;
                DBconnection.ExecuteNonQuery(deletechequeentry);
                loadchequeentry();
                EnableDisableControl("Reset");
            }
        }

        private void btnnew_Click(object sender, EventArgs e)
        {
            IsEditMode = false;
            EnableDisableControl("New");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            IsEditMode = true;
            EnableDisableControl("Edit");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            EnableDisableControl("Reset");
        }

        private void dateTimeentry_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select * from chequeentry ";
                var dataList = DBconnection.gettablebyquery(sql);
                dataGridchequeentry.DataSource = dataList;
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
