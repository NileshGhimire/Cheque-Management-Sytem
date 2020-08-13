namespace cheque_management
{
    partial class partyentry
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtpartyid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtmblno = new System.Windows.Forms.TextBox();
            this.txtprtyadrs = new System.Windows.Forms.TextBox();
            this.txtprtyname = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridpartyentry = new System.Windows.Forms.DataGridView();
            this.PartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MobileNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpartyentry)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1290, 34);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Party Entry For Cheque Management System";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnreset);
            this.groupBox3.Controls.Add(this.btndelete);
            this.groupBox3.Controls.Add(this.btnnew);
            this.groupBox3.Location = new System.Drawing.Point(9, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1281, 53);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Image = global::cheque_management.Properties.Resources.Rotate_Left_32;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(995, 12);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(120, 35);
            this.btnreset.TabIndex = 13;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Image = global::cheque_management.Properties.Resources.Delete_32;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(1146, 13);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(115, 32);
            this.btndelete.TabIndex = 12;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnew.Image = global::cheque_management.Properties.Resources.Create_New_32;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(715, 10);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(120, 35);
            this.btnnew.TabIndex = 12;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Controls.Add(this.txtpartyid);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.txtuserid);
            this.groupBox4.Controls.Add(this.txtphone);
            this.groupBox4.Controls.Add(this.txtmblno);
            this.groupBox4.Controls.Add(this.txtprtyadrs);
            this.groupBox4.Controls.Add(this.txtprtyname);
            this.groupBox4.Controls.Add(this.label);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(935, 119);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 384);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "PartyEntry";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btnedit
            // 
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Image = global::cheque_management.Properties.Resources.Edit_32;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(165, 307);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(127, 42);
            this.btnedit.TabIndex = 15;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtpartyid
            // 
            this.txtpartyid.Location = new System.Drawing.Point(165, 34);
            this.txtpartyid.Name = "txtpartyid";
            this.txtpartyid.Size = new System.Drawing.Size(144, 26);
            this.txtpartyid.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Party ID:";
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Image = global::cheque_management.Properties.Resources.Save_32;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(33, 307);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(112, 42);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(165, 259);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(144, 26);
            this.txtuserid.TabIndex = 10;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(165, 209);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(144, 26);
            this.txtphone.TabIndex = 9;
            // 
            // txtmblno
            // 
            this.txtmblno.Location = new System.Drawing.Point(165, 165);
            this.txtmblno.Name = "txtmblno";
            this.txtmblno.Size = new System.Drawing.Size(144, 26);
            this.txtmblno.TabIndex = 8;
            // 
            // txtprtyadrs
            // 
            this.txtprtyadrs.Location = new System.Drawing.Point(165, 116);
            this.txtprtyadrs.Name = "txtprtyadrs";
            this.txtprtyadrs.Size = new System.Drawing.Size(144, 26);
            this.txtprtyadrs.TabIndex = 7;
            // 
            // txtprtyname
            // 
            this.txtprtyname.Location = new System.Drawing.Point(165, 73);
            this.txtprtyname.Name = "txtprtyname";
            this.txtprtyname.Size = new System.Drawing.Size(144, 26);
            this.txtprtyname.TabIndex = 6;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(22, 215);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(98, 20);
            this.label.TabIndex = 5;
            this.label.Text = "Telephone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "UserId:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "MobileNo:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Party Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Party Name:";
            // 
            // dataGridpartyentry
            // 
            this.dataGridpartyentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridpartyentry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartyId,
            this.PartyName,
            this.PartyAddress,
            this.MobileNo,
            this.Telephone,
            this.UserId});
            this.dataGridpartyentry.Location = new System.Drawing.Point(0, 99);
            this.dataGridpartyentry.Name = "dataGridpartyentry";
            this.dataGridpartyentry.Size = new System.Drawing.Size(929, 426);
            this.dataGridpartyentry.TabIndex = 0;
            this.dataGridpartyentry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridpartyentry_CellContentClick);
            // 
            // PartyId
            // 
            this.PartyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartyId.DataPropertyName = "PartyId";
            this.PartyId.HeaderText = "PartyID";
            this.PartyId.Name = "PartyId";
            // 
            // PartyName
            // 
            this.PartyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartyName.DataPropertyName = "PartyName";
            this.PartyName.HeaderText = "PartyName";
            this.PartyName.Name = "PartyName";
            // 
            // PartyAddress
            // 
            this.PartyAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartyAddress.DataPropertyName = "PartyAddress";
            this.PartyAddress.HeaderText = "PartyAddress";
            this.PartyAddress.Name = "PartyAddress";
            // 
            // MobileNo
            // 
            this.MobileNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MobileNo.DataPropertyName = "MobileNo";
            this.MobileNo.HeaderText = "MobileNo";
            this.MobileNo.Name = "MobileNo";
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserID";
            this.UserId.HeaderText = "UserID";
            this.UserId.Name = "UserId";
            // 
            // partyentry
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1302, 556);
            this.Controls.Add(this.dataGridpartyentry);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "partyentry";
            this.Text = "partyentry";
            this.Load += new System.EventHandler(this.partyentry_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridpartyentry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridpartyentry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtmblno;
        private System.Windows.Forms.TextBox txtprtyadrs;
        private System.Windows.Forms.TextBox txtprtyname;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.TextBox txtpartyid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn MobileNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
    }
}