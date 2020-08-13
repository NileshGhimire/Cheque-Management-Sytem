namespace cheque_management
{
    partial class userid
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btndlt = new System.Windows.Forms.Button();
            this.dataGridUserEntry = new System.Windows.Forms.DataGridView();
            this.UserID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtstaffname = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpswrd = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserEntry)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 28);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(0, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(165, 50);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search User";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnnew);
            this.groupBox3.Controls.Add(this.btnreset);
            this.groupBox3.Controls.Add(this.btndlt);
            this.groupBox3.Location = new System.Drawing.Point(171, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // btnnew
            // 
            this.btnnew.Image = global::cheque_management.Properties.Resources.Create_New_32;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(34, 11);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(93, 38);
            this.btnnew.TabIndex = 8;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnreset
            // 
            this.btnreset.Image = global::cheque_management.Properties.Resources.Rotate_Left_32;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(187, 11);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(98, 39);
            this.btnreset.TabIndex = 7;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btndlt
            // 
            this.btndlt.Image = global::cheque_management.Properties.Resources.Delete_32;
            this.btndlt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndlt.Location = new System.Drawing.Point(321, 10);
            this.btndlt.Name = "btndlt";
            this.btndlt.Size = new System.Drawing.Size(121, 39);
            this.btndlt.TabIndex = 16;
            this.btndlt.Text = "Delete";
            this.btndlt.UseVisualStyleBackColor = true;
            this.btndlt.Click += new System.EventHandler(this.btndlt_Click);
            // 
            // dataGridUserEntry
            // 
            this.dataGridUserEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUserEntry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID1,
            this.StaffName,
            this.Email,
            this.UserName,
            this.Password,
            this.Telephone});
            this.dataGridUserEntry.Location = new System.Drawing.Point(0, 90);
            this.dataGridUserEntry.Name = "dataGridUserEntry";
            this.dataGridUserEntry.Size = new System.Drawing.Size(642, 311);
            this.dataGridUserEntry.TabIndex = 4;
            this.dataGridUserEntry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGriduserid_CellContentClick);
            // 
            // UserID1
            // 
            this.UserID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID1.DataPropertyName = "UserID";
            this.UserID1.HeaderText = "UserID";
            this.UserID1.Name = "UserID1";
            // 
            // StaffName
            // 
            this.StaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StaffName.DataPropertyName = "StaffName";
            this.StaffName.HeaderText = "StaffName";
            this.StaffName.Name = "StaffName";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // UserName
            // 
            this.UserName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // Telephone
            // 
            this.Telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Telephone.DataPropertyName = "Telephone";
            this.Telephone.HeaderText = "Telephone";
            this.Telephone.Name = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "User Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Staff Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Password:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Telephone:";
            // 
            // txtstaffname
            // 
            this.txtstaffname.Location = new System.Drawing.Point(146, 118);
            this.txtstaffname.Name = "txtstaffname";
            this.txtstaffname.Size = new System.Drawing.Size(147, 26);
            this.txtstaffname.TabIndex = 11;
            this.txtstaffname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(146, 163);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(147, 26);
            this.txtemail.TabIndex = 12;
            this.txtemail.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(146, 195);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(147, 26);
            this.txtusername.TabIndex = 13;
            this.txtusername.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtpswrd
            // 
            this.txtpswrd.Location = new System.Drawing.Point(146, 238);
            this.txtpswrd.Name = "txtpswrd";
            this.txtpswrd.Size = new System.Drawing.Size(147, 26);
            this.txtpswrd.TabIndex = 14;
            this.txtpswrd.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.txtuserid);
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.txtphone);
            this.groupBox4.Controls.Add(this.txtpswrd);
            this.groupBox4.Controls.Add(this.txtusername);
            this.groupBox4.Controls.Add(this.txtemail);
            this.groupBox4.Controls.Add(this.txtstaffname);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(645, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(320, 401);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "UserEntry";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "User ID:";
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(146, 70);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(147, 26);
            this.txtuserid.TabIndex = 18;
            // 
            // btnedit
            // 
            this.btnedit.Image = global::cheque_management.Properties.Resources.Edit_32;
            this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnedit.Location = new System.Drawing.Point(172, 317);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(121, 39);
            this.btnedit.TabIndex = 17;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::cheque_management.Properties.Resources.Save_32;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(6, 317);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(118, 39);
            this.btnsave.TabIndex = 5;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(146, 270);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(147, 26);
            this.txtphone.TabIndex = 15;
            this.txtphone.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // userid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(981, 402);
            this.Controls.Add(this.dataGridUserEntry);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "userid";
            this.Text = "userid";
            this.Load += new System.EventHandler(this.userid_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUserEntry)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridUserEntry;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtstaffname;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpswrd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndlt;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StaffName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
    }
}