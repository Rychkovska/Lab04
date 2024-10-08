﻿namespace Lab04
{
	partial class fMain
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

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDel = new System.Windows.Forms.ToolStripButton();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnExit = new System.Windows.Forms.ToolStripButton();
			this.gvBooks = new System.Windows.Forms.DataGridView();
			this.bindSrcBooks = new System.Windows.Forms.BindingSource(this.components);
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvBooks)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcBooks)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.tsSeparator1,
            this.btnDel,
            this.btnClear,
            this.tsSeparator2,
            this.btnExit});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(848, 27);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(24, 24);
			this.btnAdd.Text = "Додати запис про книгу";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(24, 24);
			this.btnEdit.Text = "Редагувати запис ";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// tsSeparator1
			// 
			this.tsSeparator1.Name = "tsSeparator1";
			this.tsSeparator1.Size = new System.Drawing.Size(6, 27);
			// 
			// btnDel
			// 
			this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
			this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(24, 24);
			this.btnDel.Text = "Видалити запис ";
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnClear
			// 
			this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(24, 24);
			this.btnClear.Text = "Очистити дані";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// tsSeparator2
			// 
			this.tsSeparator2.Name = "tsSeparator2";
			this.tsSeparator2.Size = new System.Drawing.Size(6, 27);
			// 
			// btnExit
			// 
			this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
			this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(24, 24);
			this.btnExit.Text = "Вийти з програми";
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// gvBooks
			// 
			this.gvBooks.AllowUserToAddRows = false;
			this.gvBooks.AllowUserToDeleteRows = false;
			this.gvBooks.AutoGenerateColumns = false;
			this.gvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gvBooks.DataSource = this.bindSrcBooks;
			this.gvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gvBooks.Location = new System.Drawing.Point(0, 27);
			this.gvBooks.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.gvBooks.Name = "gvBooks";
			this.gvBooks.ReadOnly = true;
			this.gvBooks.RowHeadersWidth = 51;
			this.gvBooks.RowTemplate.Height = 24;
			this.gvBooks.Size = new System.Drawing.Size(848, 339);
			this.gvBooks.TabIndex = 1;
			// 
			// fMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(848, 366);
			this.Controls.Add(this.gvBooks);
			this.Controls.Add(this.toolStrip1);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "fMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Лабораторна робота №4";
			this.Load += new System.EventHandler(this.fMain_Load);
			this.Resize += new System.EventHandler(this.fMain_Resize);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gvBooks)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bindSrcBooks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripSeparator tsSeparator1;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnDel;
		private System.Windows.Forms.ToolStripButton btnClear;
		private System.Windows.Forms.ToolStripSeparator tsSeparator2;
		private System.Windows.Forms.ToolStripButton btnExit;
		private System.Windows.Forms.BindingSource bindSrcBooks;
		private System.Windows.Forms.DataGridView gvBooks;

	}
}
