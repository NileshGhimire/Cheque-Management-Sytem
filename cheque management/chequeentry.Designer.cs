namespace cheque_management
{
    partial class chequeentry
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.dateTimedateofcash = new System.Windows.Forms.DateTimePicker();
            this.dateTimeentrydate = new System.Windows.Forms.DateTimePicker();
            this.txtprtyid = new System.Windows.Forms.TextBox();
            this.txtchqno = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtchqbearer = new System.Windows.Forms.TextBox();
            this.txtbnkid = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridchequeentry = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimeentry = new System.Windows.Forms.DateTimePicker();
            this.btnnew = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtchequeid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BankID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartyId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChequeBearer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridchequeentry)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(404, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(88, 77);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtchequeid);
            this.groupBox4.Controls.Add(this.btnupdate);
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.dateTimedateofcash);
            this.groupBox4.Controls.Add(this.dateTimeentrydate);
            this.groupBox4.Controls.Add(this.txtprtyid);
            this.groupBox4.Controls.Add(this.txtchqno);
            this.groupBox4.Controls.Add(this.txtuserid);
            this.groupBox4.Controls.Add(this.txtchqbearer);
            this.groupBox4.Controls.Add(this.txtbnkid);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(836, 120);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(373, 458);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cheque Entry";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // btndelete
            // 
            this.btndelete.Image = global::cheque_management.Properties.Resources.Delete_32;
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.Location = new System.Drawing.Point(121, 366);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(112, 33);
            this.btndelete.TabIndex = 19;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.Image = global::cheque_management.Properties.Resources.Save_32;
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsave.Location = new System.Drawing.Point(9, 366);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(106, 33);
            this.btnsave.TabIndex = 18;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // dateTimedateofcash
            // 
            this.dateTimedateofcash.CustomFormat = "MM-dd-yyyy";
            this.dateTimedateofcash.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimedateofcash.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimedateofcash.Location = new System.Drawing.Point(157, 249);
            this.dateTimedateofcash.Name = "dateTimedateofcash";
            this.dateTimedateofcash.Size = new System.Drawing.Size(178, 20);
            this.dateTimedateofcash.TabIndex = 17;
            this.dateTimedateofcash.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimeentrydate
            // 
            this.dateTimeentrydate.CustomFormat = "MM-dd-yyyy";
            this.dateTimeentrydate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeentrydate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeentrydate.Location = new System.Drawing.Point(157, 210);
            this.dateTimeentrydate.Name = "dateTimeentrydate";
            this.dateTimeentrydate.Size = new System.Drawing.Size(178, 20);
            this.dateTimeentrydate.TabIndex = 16;
            this.dateTimeentrydate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtprtyid
            // 
            this.txtprtyid.Location = new System.Drawing.Point(157, 97);
            this.txtprtyid.Name = "txtprtyid";
            this.txtprtyid.Size = new System.Drawing.Size(176, 26);
            this.txtprtyid.TabIndex = 15;
            this.txtprtyid.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtchqno
            // 
            this.txtchqno.Location = new System.Drawing.Point(159, 137);
            this.txtchqno.Name = "txtchqno";
            this.txtchqno.Size = new System.Drawing.Size(176, 26);
            this.txtchqno.TabIndex = 14;
            this.txtchqno.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(159, 282);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(176, 26);
            this.txtuserid.TabIndex = 13;
            this.txtuserid.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtchqbearer
            // 
            this.txtchqbearer.Location = new System.Drawing.Point(157, 175);
            this.txtchqbearer.Name = "txtchqbearer";
            this.txtchqbearer.Size = new System.Drawing.Size(176, 26);
            this.txtchqbearer.TabIndex = 12;
            this.txtchqbearer.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtbnkid
            // 
            this.txtbnkid.Location = new System.Drawing.Point(157, 58);
            this.txtbnkid.Name = "txtbnkid";
            this.txtbnkid.Size = new System.Drawing.Size(176, 26);
            this.txtbnkid.TabIndex = 11;
            this.txtbnkid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bank Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Date Of Cash:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Cheque No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cheque Bearer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Entry Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "UserID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "PartyId:";
            // 
            // dataGridchequeentry
            // 
            this.dataGridchequeentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridchequeentry.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BankID,
            this.PartyId,
            this.ChequeNo,
            this.ChequeBearer,
            this.EntryDate,
            this.DateOfCash,
            this.UserId});
            this.dataGridchequeentry.Location = new System.Drawing.Point(-1, 114);
            this.dataGridchequeentry.Name = "dataGridchequeentry";
            this.dataGridchequeentry.Size = new System.Drawing.Size(831, 474);
            this.dataGridchequeentry.TabIndex = 0;
            this.dataGridchequeentry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridchequeentry_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Home";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(-1, -6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1170, 36);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(125, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Cheque Search";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(5, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimeentry);
            this.groupBox2.Controls.Add(this.btnnew);
            this.groupBox2.Controls.Add(this.btnreset);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(430, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // dateTimeentry
            // 
            this.dateTimeentry.CustomFormat = "MM-dd-yyyy";
            this.dateTimeentry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeentry.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeentry.Location = new System.Drawing.Point(188, 26);
            this.dateTimeentry.Name = "dateTimeentry";
            this.dateTimeentry.Size = new System.Drawing.Size(183, 20);
            this.dateTimeentry.TabIndex = 22;
            this.dateTimeentry.ValueChanged += new System.EventHandler(this.dateTimeentry_ValueChanged);
            // 
            // btnnew
            // 
            this.btnnew.Image = global::cheque_management.Properties.Resources.Create_New_32;
            this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnnew.Location = new System.Drawing.Point(454, 22);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(107, 33);
            this.btnnew.TabIndex = 21;
            this.btnnew.Text = "New";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // btnreset
            // 
            this.btnreset.Image = global::cheque_management.Properties.Resources.Rotate_Left_32;
            this.btnreset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreset.Location = new System.Drawing.Point(593, 22);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(107, 33);
            this.btnreset.TabIndex = 20;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = " Search By EntryDate:";
            // 
            // btnupdate
            // 
            this.btnupdate.Image = global::cheque_management.Properties.Resources.Edit_32;
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.Location = new System.Drawing.Point(239, 366);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(125, 33);
            this.btnupdate.TabIndex = 20;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtchequeid
            // 
            this.txtchequeid.Location = new System.Drawing.Point(157, 25);
            this.txtchequeid.Name = "txtchequeid";
            this.txtchequeid.Size = new System.Drawing.Size(176, 26);
            this.txtchequeid.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Cheque Id:";
            // 
            // BankID
            // 
            this.BankID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BankID.DataPropertyName = "BankId";
            this.BankID.HeaderText = "BankId";
            this.BankID.Name = "BankID";
            // 
            // PartyId
            // 
            this.PartyId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PartyId.DataPropertyName = "PartyId";
            this.PartyId.HeaderText = "PartyId";
            this.PartyId.Name = "PartyId";
            // 
            // ChequeNo
            // 
            this.ChequeNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChequeNo.DataPropertyName = "ChequeNo";
            this.ChequeNo.HeaderText = "ChequeNo";
            this.ChequeNo.Name = "ChequeNo";
            // 
            // ChequeBearer
            // 
            this.ChequeBearer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChequeBearer.DataPropertyName = "ChequeBearer";
            this.ChequeBearer.HeaderText = "ChequeBearer";
            this.ChequeBearer.Name = "ChequeBearer";
            // 
            // EntryDate
            // 
            this.EntryDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EntryDate.DataPropertyName = "EntryDate";
            this.EntryDate.HeaderText = "EntryDate";
            this.EntryDate.Name = "EntryDate";
            // 
            // DateOfCash
            // 
            this.DateOfCash.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateOfCash.DataPropertyName = "DateOfCash";
            this.DateOfCash.HeaderText = "DateOfCash";
            this.DateOfCash.Name = "DateOfCash";
            // 
            // UserId
            // 
            this.UserId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            // 
            // chequeentry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1212, 579);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.dataGridchequeentry);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "chequeentry";
            this.Text = "chequeentry";
            this.Load += new System.EventHandler(this.chequeentry_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridchequeentry)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridchequeentry;
        private System.Windows.Forms.TextBox txtprtyid;
        private System.Windows.Forms.TextBox txtchqno;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtchqbearer;
        private System.Windows.Forms.TextBox txtbnkid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimedateofcash;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnnew;
        private System.Windows.Forms.DateTimePicker dateTimeentrydate;
        private System.Windows.Forms.DateTimePicker dateTimeentry;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtchequeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartyId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChequeBearer;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCash;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
    }
}