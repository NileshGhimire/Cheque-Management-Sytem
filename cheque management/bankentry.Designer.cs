namespace cheque_management
{
    partial class bankentry
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtbnkid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbnkaddrss = new System.Windows.Forms.TextBox();
            this.txtbnkname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridbankentry = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.BankId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbankentry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(226, 59);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Entry";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnreset);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Controls.Add(this.btnedit);
            this.groupBox2.Location = new System.Drawing.Point(226, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 59);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.Image = global::cheque_management.Properties.Resources.Rotate_Left_32;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnreset.Location = new System.Drawing.Point(404, 11);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(117, 42);
            this.btnreset.TabIndex = 10;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::cheque_management.Properties.Resources.Create_New_32;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnnew.Location = new System.Drawing.Point(78, 10);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(116, 42);
            this.btnnew.TabIndex = 9;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnedit
            // 
            this.btnedit.Image = global::cheque_management.Properties.Resources.Edit_32;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnedit.Location = new System.Drawing.Point(249, 10);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(117, 42);
            this.btnedit.TabIndex = 8;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnsave);
            this.groupBox3.Controls.Add(this.txtbnkid);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtbnkaddrss);
            this.groupBox3.Controls.Add(this.txtbnkname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(488, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 274);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank Entry ";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::cheque_management.Properties.Resources.Delete_32;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btndelete.Location = new System.Drawing.Point(173, 198);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(123, 42);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::cheque_management.Properties.Resources.Save_32;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsave.Location = new System.Drawing.Point(40, 198);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 42);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtbnkid
            // 
            this.txtbnkid.Location = new System.Drawing.Point(160, 46);
            this.txtbnkid.Name = "txtbnkid";
            this.txtbnkid.Size = new System.Drawing.Size(136, 26);
            this.txtbnkid.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bank Id:";
            // 
            // txtbnkaddrss
            // 
            this.txtbnkaddrss.Location = new System.Drawing.Point(160, 136);
            this.txtbnkaddrss.Name = "txtbnkaddrss";
            this.txtbnkaddrss.Size = new System.Drawing.Size(136, 26);
            this.txtbnkaddrss.TabIndex = 4;
            // 
            // txtbnkname
            // 
            this.txtbnkname.Location = new System.Drawing.Point(160, 85);
            this.txtbnkname.Name = "txtbnkname";
            this.txtbnkname.Size = new System.Drawing.Size(136, 26);
            this.txtbnkname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Bank Address:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bank Name:";
            // 
            // dataGridbankentry
            // 
            this.dataGridbankentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridbankentry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankId,
            this.BankName,
            this.BankAddress});
            this.dataGridbankentry.Location = new System.Drawing.Point(3, 86);
            this.dataGridbankentry.Name = "dataGridbankentry";
            this.dataGridbankentry.Size = new System.Drawing.Size(479, 272);
            this.dataGridbankentry.TabIndex = 3;
            this.dataGridbankentry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-1, -2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Home";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // BankId
            // 
            this.BankId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BankId.DataPropertyName = "BankId";
            this.BankId.HeaderText = "BankId";
            this.BankId.Name = "BankId";
            // 
            // BankName
            // 
            this.BankName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BankName.DataPropertyName = "BankName";
            this.BankName.HeaderText = "BankName";
            this.BankName.Name = "BankName";
            // 
            // BankAddress
            // 
            this.BankAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BankAddress.DataPropertyName = "BankAddress";
            this.BankAddress.HeaderText = "BankAddress";
            this.BankAddress.Name = "BankAddress";
            // 
            // bankentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 358);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridbankentry);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "bankentry";
            this.Text = "bankentry";
            this.Load += new System.EventHandler(this.bankentry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridbankentry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtbnkid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbnkaddrss;
        private System.Windows.Forms.TextBox txtbnkname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridbankentry;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankId;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankAddress;
    }
}