﻿namespace QuanLyQuanCafe
{
    partial class Danhmuc
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTenDM = new System.Windows.Forms.TextBox();
            this.txtIDDM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iBtnDSBxem = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBsua = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBxoa = new FontAwesome.Sharp.IconButton();
            this.iBtnDSBthem = new FontAwesome.Sharp.IconButton();
            this.dgvDanhMuc = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtTenDM);
            this.panel1.Controls.Add(this.txtIDDM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(623, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 593);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = global::QuanLyQuanCafe.Properties.Resources.pngtree_milk_tea_cold_drink_summer_drink_poster_background_material_image_1479811;
            this.pictureBox2.Image = global::QuanLyQuanCafe.Properties.Resources.pngtree_milk_tea_cold_drink_summer_drink_poster_background_material_image_147981;
            this.pictureBox2.Location = new System.Drawing.Point(161, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 89);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyQuanCafe.Properties.Resources.A_small_cup_of_coffee;
            this.pictureBox1.Location = new System.Drawing.Point(19, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtTenDM
            // 
            this.txtTenDM.Location = new System.Drawing.Point(117, 292);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.Size = new System.Drawing.Size(162, 20);
            this.txtTenDM.TabIndex = 5;
            // 
            // txtIDDM
            // 
            this.txtIDDM.Location = new System.Drawing.Point(117, 217);
            this.txtIDDM.Name = "txtIDDM";
            this.txtIDDM.Size = new System.Drawing.Size(162, 20);
            this.txtIDDM.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "QUẢN LÝ DANH MỤC";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(6, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên danh mục";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(85, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
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
            this.panel2.Size = new System.Drawing.Size(623, 81);
            this.panel2.TabIndex = 3;
            // 
            // iBtnDSBxem
            // 
            this.iBtnDSBxem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.iBtnDSBxem.FlatAppearance.BorderSize = 0;
            this.iBtnDSBxem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iBtnDSBxem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxem.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.iBtnDSBxem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxem.Location = new System.Drawing.Point(453, 6);
            this.iBtnDSBxem.Name = "iBtnDSBxem";
            this.iBtnDSBxem.Size = new System.Drawing.Size(118, 54);
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
            this.iBtnDSBsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBsua.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBsua.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.iBtnDSBsua.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBsua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBsua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBsua.Location = new System.Drawing.Point(307, 6);
            this.iBtnDSBsua.Name = "iBtnDSBsua";
            this.iBtnDSBsua.Size = new System.Drawing.Size(118, 54);
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
            this.iBtnDSBxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBxoa.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBxoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.iBtnDSBxoa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBxoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBxoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBxoa.Location = new System.Drawing.Point(165, 6);
            this.iBtnDSBxoa.Name = "iBtnDSBxoa";
            this.iBtnDSBxoa.Size = new System.Drawing.Size(118, 54);
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
            this.iBtnDSBthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iBtnDSBthem.ForeColor = System.Drawing.Color.White;
            this.iBtnDSBthem.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iBtnDSBthem.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.iBtnDSBthem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iBtnDSBthem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iBtnDSBthem.Location = new System.Drawing.Point(21, 6);
            this.iBtnDSBthem.Name = "iBtnDSBthem";
            this.iBtnDSBthem.Size = new System.Drawing.Size(118, 54);
            this.iBtnDSBthem.TabIndex = 0;
            this.iBtnDSBthem.Text = "Thêm";
            this.iBtnDSBthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iBtnDSBthem.UseVisualStyleBackColor = false;
            this.iBtnDSBthem.Click += new System.EventHandler(this.iBtnDSBthem_Click);
            // 
            // dgvDanhMuc
            // 
            this.dgvDanhMuc.AllowUserToAddRows = false;
            this.dgvDanhMuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhMuc.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDanhMuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhMuc.Location = new System.Drawing.Point(0, 81);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersWidth = 51;
            this.dgvDanhMuc.Size = new System.Drawing.Size(623, 512);
            this.dgvDanhMuc.TabIndex = 4;
            // 
            // Danhmuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 593);
            this.Controls.Add(this.dgvDanhMuc);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Danhmuc";
            this.Text = "Danhmuc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtTenDM;
        private System.Windows.Forms.TextBox txtIDDM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton iBtnDSBxem;
        private FontAwesome.Sharp.IconButton iBtnDSBsua;
        private FontAwesome.Sharp.IconButton iBtnDSBxoa;
        private FontAwesome.Sharp.IconButton iBtnDSBthem;
        private System.Windows.Forms.DataGridView dgvDanhMuc;
    }
}