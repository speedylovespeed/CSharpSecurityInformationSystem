﻿namespace CSharpSecurityInformationSystem
{
    partial class UserControlAccnt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvaccnts = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_pass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_lname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbxusernam = new System.Windows.Forms.TextBox();
            this.txtbxuserpass = new System.Windows.Forms.TextBox();
            this.txtbxfname = new System.Windows.Forms.TextBox();
            this.txtbxlname = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.cmbxusertype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccnts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Accounts";
            // 
            // dgvaccnts
            // 
            this.dgvaccnts.AllowUserToAddRows = false;
            this.dgvaccnts.AllowUserToDeleteRows = false;
            this.dgvaccnts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvaccnts.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvaccnts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvaccnts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvaccnts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.user_pass,
            this.user_type,
            this.user_fname,
            this.user_lname});
            this.dgvaccnts.Location = new System.Drawing.Point(23, 51);
            this.dgvaccnts.Name = "dgvaccnts";
            this.dgvaccnts.ReadOnly = true;
            this.dgvaccnts.Size = new System.Drawing.Size(817, 529);
            this.dgvaccnts.TabIndex = 1;
            this.dgvaccnts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvaccnts_CellDoubleClick);
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "user_id";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "Username";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // user_pass
            // 
            this.user_pass.DataPropertyName = "user_pass";
            this.user_pass.HeaderText = "Password";
            this.user_pass.Name = "user_pass";
            this.user_pass.ReadOnly = true;
            // 
            // user_type
            // 
            this.user_type.DataPropertyName = "user_type";
            this.user_type.HeaderText = "Type";
            this.user_type.Name = "user_type";
            this.user_type.ReadOnly = true;
            // 
            // user_fname
            // 
            this.user_fname.DataPropertyName = "user_fname";
            this.user_fname.HeaderText = "First Name";
            this.user_fname.Name = "user_fname";
            this.user_fname.ReadOnly = true;
            // 
            // user_lname
            // 
            this.user_lname.DataPropertyName = "user_lname";
            this.user_lname.HeaderText = "Last Name";
            this.user_lname.Name = "user_lname";
            this.user_lname.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(854, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username   :";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(854, 66);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(55, 15);
            this.lbluserid.TabIndex = 3;
            this.lbluserid.Text = "user_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(854, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password    :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(854, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type               :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(854, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(854, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Last Name   :";
            // 
            // txtbxusernam
            // 
            this.txtbxusernam.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxusernam.Location = new System.Drawing.Point(947, 109);
            this.txtbxusernam.Name = "txtbxusernam";
            this.txtbxusernam.Size = new System.Drawing.Size(155, 27);
            this.txtbxusernam.TabIndex = 6;
            this.txtbxusernam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxuserpass
            // 
            this.txtbxuserpass.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxuserpass.Location = new System.Drawing.Point(947, 151);
            this.txtbxuserpass.Name = "txtbxuserpass";
            this.txtbxuserpass.Size = new System.Drawing.Size(155, 27);
            this.txtbxuserpass.TabIndex = 6;
            this.txtbxuserpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxfname
            // 
            this.txtbxfname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxfname.Location = new System.Drawing.Point(947, 221);
            this.txtbxfname.Name = "txtbxfname";
            this.txtbxfname.Size = new System.Drawing.Size(155, 27);
            this.txtbxfname.TabIndex = 6;
            this.txtbxfname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbxlname
            // 
            this.txtbxlname.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxlname.Location = new System.Drawing.Point(947, 257);
            this.txtbxlname.Name = "txtbxlname";
            this.txtbxlname.Size = new System.Drawing.Size(155, 27);
            this.txtbxlname.TabIndex = 6;
            this.txtbxlname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnsave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsave.FlatAppearance.BorderSize = 0;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsave.Location = new System.Drawing.Point(868, 315);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(100, 33);
            this.btnsave.TabIndex = 10;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdate.FlatAppearance.BorderSize = 0;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Location = new System.Drawing.Point(996, 315);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(100, 33);
            this.btnupdate.TabIndex = 10;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btndelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndelete.Location = new System.Drawing.Point(868, 381);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 33);
            this.btndelete.TabIndex = 10;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnclear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclear.FlatAppearance.BorderSize = 0;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclear.Location = new System.Drawing.Point(996, 381);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(100, 33);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // cmbxusertype
            // 
            this.cmbxusertype.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxusertype.FormattingEnabled = true;
            this.cmbxusertype.Items.AddRange(new object[] {
            "\tadmin",
            "\tuser"});
            this.cmbxusertype.Location = new System.Drawing.Point(947, 187);
            this.cmbxusertype.Name = "cmbxusertype";
            this.cmbxusertype.Size = new System.Drawing.Size(155, 28);
            this.cmbxusertype.TabIndex = 11;
            // 
            // UserControlAccnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cmbxusertype);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtbxlname);
            this.Controls.Add(this.txtbxfname);
            this.Controls.Add(this.txtbxuserpass);
            this.Controls.Add(this.txtbxusernam);
            this.Controls.Add(this.lbluserid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvaccnts);
            this.Controls.Add(this.label1);
            this.Name = "UserControlAccnt";
            this.Size = new System.Drawing.Size(1129, 630);
            this.Load += new System.EventHandler(this.UserControlAccnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvaccnts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvaccnts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtbxusernam;
        internal System.Windows.Forms.TextBox txtbxuserpass;
        internal System.Windows.Forms.TextBox txtbxfname;
        internal System.Windows.Forms.TextBox txtbxlname;
        internal System.Windows.Forms.Button btnsave;
        internal System.Windows.Forms.Button btnupdate;
        internal System.Windows.Forms.Button btndelete;
        internal System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.ComboBox cmbxusertype;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_pass;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_lname;
    }
}
