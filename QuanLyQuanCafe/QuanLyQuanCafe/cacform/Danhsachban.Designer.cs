﻿namespace QuanLyQuanCafe
{
    partial class Danhsachban
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbTrangThai = new System.Windows.Forms.ComboBox();
            this.txtTenBan = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnDSBxem = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBsua = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBxoa = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBthem = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvDanhsachban = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbTrangThai);
            this.panel1.Controls.Add(this.txtTenBan);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(610, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 593);
            this.panel1.TabIndex = 0;
            // 
            // cbTrangThai
            // 
            this.cbTrangThai.FormattingEnabled = true;
            this.cbTrangThai.Location = new System.Drawing.Point(87, 280);
            this.cbTrangThai.Name = "cbTrangThai";
            this.cbTrangThai.Size = new System.Drawing.Size(182, 21);
            this.cbTrangThai.TabIndex = 6;
            // 
            // txtTenBan
            // 
            this.txtTenBan.Location = new System.Drawing.Point(87, 209);
            this.txtTenBan.Name = "txtTenBan";
            this.txtTenBan.Size = new System.Drawing.Size(182, 20);
            this.txtTenBan.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(86, 137);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(182, 20);
            this.txtID.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(44, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ BÀN ĂN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(10, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(22, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bàn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(60, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iBtnDSBxem);
            this.panel2.Controls.Add(this.iBtnDSBsua);
            this.panel2.Controls.Add(this.iBtnDSBxoa);
            this.panel2.Controls.Add(this.iBtnDSBthem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(610, 81);
            this.panel2.TabIndex = 1;
            // 
            // iBtnDSBxem
            // 
            this.iBtnDSBxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBxem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBtnDSBxem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxem.Location = new System.Drawing.Point(453, 10);
            this.iBtnDSBxem.Name = "iBtnDSBxem";
            this.iBtnDSBxem.Size = new System.Drawing.Size(118, 57);
            this.iBtnDSBxem.TabIndex = 3;
            this.iBtnDSBxem.Text = "Xem";
            this.iBtnDSBxem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxem.UseVisualStyleBackColor = false;
            this.iBtnDSBxem.Click += new System.EventHandler(this.iBtnDSBxem_Click);
            // 
            // iBtnDSBsua
            // 
            this.iBtnDSBsua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBsua.FlatAppearance.BorderSize = 0;
            this.iBtnDSBsua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBsua.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBsua.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBsua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iBtnDSBsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBsua.Location = new System.Drawing.Point(307, 10);
            this.iBtnDSBsua.Name = "iBtnDSBsua";
            this.iBtnDSBsua.Size = new System.Drawing.Size(118, 57);
            this.iBtnDSBsua.TabIndex = 2;
            this.iBtnDSBsua.Text = "Sửa";
            this.iBtnDSBsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBsua.UseVisualStyleBackColor = false;
            this.iBtnDSBsua.Click += new System.EventHandler(this.iBtnDSBsua_Click);
            // 
            // iBtnDSBxoa
            // 
            this.iBtnDSBxoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBxoa.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxoa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxoa.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDSBxoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxoa.Location = new System.Drawing.Point(165, 10);
            this.iBtnDSBxoa.Name = "iBtnDSBxoa";
            this.iBtnDSBxoa.Size = new System.Drawing.Size(118, 57);
            this.iBtnDSBxoa.TabIndex = 1;
            this.iBtnDSBxoa.Text = "Xoá";
            this.iBtnDSBxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBxoa.UseVisualStyleBackColor = false;
            this.iBtnDSBxoa.Click += new System.EventHandler(this.iBtnDSBxoa_Click);
            // 
            // iBtnDSBthem
            // 
            this.iBtnDSBthem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBthem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBthem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBthem.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBthem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBthem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDSBthem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBthem.Location = new System.Drawing.Point(21, 10);
            this.iBtnDSBthem.Name = "iBtnDSBthem";
            this.iBtnDSBthem.Size = new System.Drawing.Size(118, 57);
            this.iBtnDSBthem.TabIndex = 0;
            this.iBtnDSBthem.Text = "Thêm";
            this.iBtnDSBthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBthem.UseVisualStyleBackColor = false;
            this.iBtnDSBthem.Click += new System.EventHandler(this.iBtnDSBthem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvDanhsachban);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 512);
            this.panel3.TabIndex = 2;
            // 
            // dgvDanhsachban
            // 
            this.dgvDanhsachban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhsachban.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhsachban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhsachban.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhsachban.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhsachban.Name = "dgvDanhsachban";
            this.dgvDanhsachban.RowHeadersWidth = 51;
            this.dgvDanhsachban.Size = new System.Drawing.Size(610, 512);
            this.dgvDanhsachban.TabIndex = 0;
            // 
            // Danhsachban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 593);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Danhsachban";
            this.Text = "Danhsachban";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhsachban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvDanhsachban;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iBtnDSBxem;
        private FontAwesome.Sharp.IconButton iBtnDSBsua;
        private FontAwesome.Sharp.IconButton iBtnDSBxoa;
        private FontAwesome.Sharp.IconButton iBtnDSBthem;
        private System.Windows.Forms.TextBox txtTenBan;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTrangThai;
    }
}