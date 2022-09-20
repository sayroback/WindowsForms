﻿namespace AppEscritorioForms
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
      this.components = new System.ComponentModel.Container();
      this.gridContacts = new System.Windows.Forms.DataGridView();
      this.btnSearch = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.btnBrowser = new System.Windows.Forms.Button();
      this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
      ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridContacts
      // 
      this.gridContacts.AutoGenerateColumns = false;
      this.gridContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.Edit});
      this.gridContacts.DataSource = this.contactBindingSource;
      this.gridContacts.Location = new System.Drawing.Point(12, 96);
      this.gridContacts.Name = "gridContacts";
      this.gridContacts.Size = new System.Drawing.Size(635, 289);
      this.gridContacts.TabIndex = 0;
      this.gridContacts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridContacts_CellContentClick);
      // 
      // btnSearch
      // 
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(425, 39);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 35);
      this.btnSearch.TabIndex = 3;
      this.btnSearch.Text = "Search";
      this.btnSearch.UseVisualStyleBackColor = true;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(518, 39);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 35);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "Add";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearch.Location = new System.Drawing.Point(119, 42);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(291, 29);
      this.txtSearch.TabIndex = 6;
      this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(22, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(70, 24);
      this.label1.TabIndex = 7;
      this.label1.Text = "Search";
      // 
      // btnBrowser
      // 
      this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBrowser.Location = new System.Drawing.Point(261, 403);
      this.btnBrowser.Name = "btnBrowser";
      this.btnBrowser.Size = new System.Drawing.Size(75, 35);
      this.btnBrowser.TabIndex = 9;
      this.btnBrowser.Text = "Browser";
      this.btnBrowser.UseVisualStyleBackColor = true;
      this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
      // 
      // contactBindingSource
      // 
      this.contactBindingSource.DataSource = typeof(AppEscritorioForms.Contact);
      // 
      // idDataGridViewTextBoxColumn
      // 
      this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
      this.idDataGridViewTextBoxColumn.HeaderText = "Id";
      this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
      // 
      // firstNameDataGridViewTextBoxColumn
      // 
      this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
      this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
      // 
      // lastNameDataGridViewTextBoxColumn
      // 
      this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
      this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
      this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
      // 
      // phoneDataGridViewTextBoxColumn
      // 
      this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
      this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
      this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
      // 
      // addressDataGridViewTextBoxColumn
      // 
      this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
      this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
      this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
      // 
      // Edit
      // 
      this.Edit.HeaderText = "Edit";
      this.Edit.Name = "Edit";
      this.Edit.ReadOnly = true;
      this.Edit.Text = "Edit";
      this.Edit.UseColumnTextForLinkValue = true;
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(659, 450);
      this.Controls.Add(this.btnBrowser);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.gridContacts);
      this.Name = "Main";
      this.Text = "Contacts";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

    #endregion

    private System.Windows.Forms.DataGridView gridContacts;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
    }
}

