namespace cheque_management
{
    partial class mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankEntryToolStripMenuItem,
            this.chequeToolStripMenuItem,
            this.partyEntryToolStripMenuItem,
            this.userIdToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankEntryToolStripMenuItem
            // 
            this.bankEntryToolStripMenuItem.Name = "bankEntryToolStripMenuItem";
            this.bankEntryToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.bankEntryToolStripMenuItem.Text = "BankEntry";
            this.bankEntryToolStripMenuItem.Click += new System.EventHandler(this.bankEntryToolStripMenuItem_Click);
            // 
            // chequeToolStripMenuItem
            // 
            this.chequeToolStripMenuItem.Name = "chequeToolStripMenuItem";
            this.chequeToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.chequeToolStripMenuItem.Text = "ChequeEntry";
            this.chequeToolStripMenuItem.Click += new System.EventHandler(this.chequeToolStripMenuItem_Click);
            // 
            // partyEntryToolStripMenuItem
            // 
            this.partyEntryToolStripMenuItem.Name = "partyEntryToolStripMenuItem";
            this.partyEntryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.partyEntryToolStripMenuItem.Text = "PartyEntry";
            this.partyEntryToolStripMenuItem.Click += new System.EventHandler(this.partyEntryToolStripMenuItem_Click);
            // 
            // userIdToolStripMenuItem
            // 
            this.userIdToolStripMenuItem.Name = "userIdToolStripMenuItem";
            this.userIdToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.userIdToolStripMenuItem.Text = "UserId";
            this.userIdToolStripMenuItem.Click += new System.EventHandler(this.userIdToolStripMenuItem_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(706, 450);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.Text = "mainform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userIdToolStripMenuItem;
    }
}