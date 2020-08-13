using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cheque_management
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void bankEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bankentry be = new bankentry();
            be.ShowDialog();
        }

        private void chequeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chequeentry ce = new chequeentry();
            ce.ShowDialog();
        }

        private void partyEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            partyentry pe = new partyentry();
            pe.ShowDialog();
        }

        private void userIdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userid ui = new userid();
            ui.ShowDialog();
        }
    }
}
